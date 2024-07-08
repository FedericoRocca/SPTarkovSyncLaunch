using System.Diagnostics;
using System.Configuration;
using System.Collections.Specialized;
using System.IO;

namespace SPTarkovSyncLaunch
{
    public partial class mainForm : Form
    {
        bool alreadyLaunched = false;
        bool Starting = false;
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveSettings();
            launchServer();
            launchClient();
        }

        private void launchServer()
        {
            try
            {
                if (alreadyLaunched == false)
                {
                    Process process = new Process()
                    {
                        StartInfo = new ProcessStartInfo(Properties.Settings.Default.servergamePath + "\\" + Properties.Settings.Default.akiServer)
                        {
                            WindowStyle = ProcessWindowStyle.Minimized,
                            UseShellExecute = true,
                            Arguments = null,
                            WorkingDirectory = Path.GetDirectoryName(Properties.Settings.Default.servergamePath + "\\" + Properties.Settings.Default.akiServer),
                        }
                    };
                    process.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void launchClient()
        {
            try
            {
                System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
                t.Interval = Convert.ToInt32(nudDelaySeconds.Value) * 1000;
                t.Tick += new EventHandler(timer_Tick);
                t.Start();

                void timer_Tick(object sender, EventArgs e)
                {
                    Process process = new Process()
                    {
                        StartInfo = new ProcessStartInfo(Properties.Settings.Default.servergamePath + "\\" + Properties.Settings.Default.akiLauncher)
                        {
                            WindowStyle = ProcessWindowStyle.Normal,
                            UseShellExecute = true,
                            Arguments = null,
                            WorkingDirectory = Path.GetDirectoryName(Properties.Settings.Default.servergamePath + "\\" + Properties.Settings.Default.akiLauncher),
                        }
                    };
                    process.Start();
                    alreadyLaunched = true;
                    if (chbCloseOnStart.Checked == true || chbCloseOnStart.Checked == false && alreadyLaunched == false)
                    {
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            try
            {
                txbServerPath.Text = Properties.Settings.Default.servergamePath;
                txbServerName.Text = Properties.Settings.Default.akiServer;
                txbGameName.Text = Properties.Settings.Default.akiLauncher;
                chbCloseOnStart.Checked = Properties.Settings.Default.closeAfterLaunch;
                nudDelaySeconds.Value = Properties.Settings.Default.startDelay;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog browserDialog = new FolderBrowserDialog();
                browserDialog.Description = "Directory of EFT Server AKI";
                if (browserDialog.ShowDialog() == DialogResult.OK)
                {
                    txbServerPath.Text = browserDialog.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.servergamePath = "C:\\";
                Properties.Settings.Default.akiServer = "Aki.Server.exe";
                Properties.Settings.Default.startDelay = 60;
                Properties.Settings.Default.akiLauncher = "Aki.Launcher.exe";
                Properties.Settings.Default.closeAfterLaunch = true;
                txbServerPath.Text = Properties.Settings.Default.servergamePath;
                txbServerName.Text = Properties.Settings.Default.akiServer;
                txbGameName.Text = Properties.Settings.Default.akiLauncher;
                chbCloseOnStart.Checked = Properties.Settings.Default.closeAfterLaunch;
                nudDelaySeconds.Value = Properties.Settings.Default.startDelay;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }

        private void saveSettings()
        {
            try
            {
                Properties.Settings.Default.servergamePath = txbServerPath.Text;
                Properties.Settings.Default.akiServer = txbServerName.Text;
                Properties.Settings.Default.akiLauncher = txbGameName.Text;
                Properties.Settings.Default.closeAfterLaunch = chbCloseOnStart.Checked;
                Properties.Settings.Default.startDelay = nudDelaySeconds.Value;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

        }
    }
}