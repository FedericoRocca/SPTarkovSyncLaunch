namespace SPTarkovSyncLaunch
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            pgbLaunching = new ProgressBar();
            btnDefault = new Button();
            btnDirectory = new Button();
            txbGameName = new TextBox();
            txbServerName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            nudDelaySeconds = new NumericUpDown();
            label2 = new Label();
            btnLaunch = new Button();
            chbCloseOnStart = new CheckBox();
            txbServerPath = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDelaySeconds).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pgbLaunching);
            groupBox1.Controls.Add(btnDefault);
            groupBox1.Controls.Add(btnDirectory);
            groupBox1.Controls.Add(txbGameName);
            groupBox1.Controls.Add(txbServerName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nudDelaySeconds);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnLaunch);
            groupBox1.Controls.Add(chbCloseOnStart);
            groupBox1.Controls.Add(txbServerPath);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(593, 199);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "SPTarkov Sync Launcher";
            // 
            // pgbLaunching
            // 
            pgbLaunching.Location = new Point(11, 107);
            pgbLaunching.Name = "pgbLaunching";
            pgbLaunching.Size = new Size(472, 29);
            pgbLaunching.TabIndex = 14;
            // 
            // btnDefault
            // 
            btnDefault.Location = new Point(489, 107);
            btnDefault.Name = "btnDefault";
            btnDefault.Size = new Size(97, 29);
            btnDefault.TabIndex = 13;
            btnDefault.Text = "Reset Defaults";
            btnDefault.UseVisualStyleBackColor = true;
            btnDefault.Click += button1_Click_1;
            // 
            // btnDirectory
            // 
            btnDirectory.Location = new Point(7, 22);
            btnDirectory.Name = "btnDirectory";
            btnDirectory.Size = new Size(124, 23);
            btnDirectory.TabIndex = 12;
            btnDirectory.Text = "SPT AKI Directory";
            btnDirectory.UseVisualStyleBackColor = true;
            btnDirectory.Click += btnDirectory_Click;
            // 
            // txbGameName
            // 
            txbGameName.AllowDrop = true;
            txbGameName.Location = new Point(282, 78);
            txbGameName.Name = "txbGameName";
            txbGameName.Size = new Size(304, 23);
            txbGameName.TabIndex = 11;
            // 
            // txbServerName
            // 
            txbServerName.AllowDrop = true;
            txbServerName.Location = new Point(283, 49);
            txbServerName.Name = "txbServerName";
            txbServerName.Size = new Size(304, 23);
            txbServerName.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 78);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 9;
            label4.Text = "Game Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 52);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 8;
            label3.Text = "Server Name";
            // 
            // nudDelaySeconds
            // 
            nudDelaySeconds.Location = new Point(137, 76);
            nudDelaySeconds.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudDelaySeconds.Name = "nudDelaySeconds";
            nudDelaySeconds.Size = new Size(52, 23);
            nudDelaySeconds.TabIndex = 7;
            nudDelaySeconds.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 79);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 4;
            label2.Text = "Launch delay (Seconds)";
            // 
            // btnLaunch
            // 
            btnLaunch.Location = new Point(10, 142);
            btnLaunch.Name = "btnLaunch";
            btnLaunch.Size = new Size(580, 52);
            btnLaunch.TabIndex = 3;
            btnLaunch.Text = "Launch!";
            btnLaunch.UseVisualStyleBackColor = true;
            btnLaunch.Click += button1_Click;
            // 
            // chbCloseOnStart
            // 
            chbCloseOnStart.AutoSize = true;
            chbCloseOnStart.CheckAlign = ContentAlignment.MiddleRight;
            chbCloseOnStart.Checked = true;
            chbCloseOnStart.CheckState = CheckState.Checked;
            chbCloseOnStart.Location = new Point(6, 51);
            chbCloseOnStart.Name = "chbCloseOnStart";
            chbCloseOnStart.Size = new Size(143, 19);
            chbCloseOnStart.TabIndex = 2;
            chbCloseOnStart.Text = "Close this after launch";
            chbCloseOnStart.UseVisualStyleBackColor = true;
            // 
            // txbServerPath
            // 
            txbServerPath.AllowDrop = true;
            txbServerPath.Location = new Point(137, 22);
            txbServerPath.Name = "txbServerPath";
            txbServerPath.Size = new Size(450, 23);
            txbServerPath.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Bottom;
            label5.Location = new Point(0, 213);
            label5.Name = "label5";
            label5.Size = new Size(232, 15);
            label5.TabIndex = 1;
            label5.Text = "Made by Magus for reddit.com/r/SPTarkov";
            // 
            // mainForm
            // 
            AcceptButton = btnLaunch;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 228);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Cursor = Cursors.Cross;
            HelpButton = true;
            MaximizeBox = false;
            Name = "mainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SPTarkov Sync Launcher";
            FormClosing += mainForm_FormClosing;
            Load += mainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDelaySeconds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txbServerPath;
        private Button btnLaunch;
        private CheckBox chbCloseOnStart;
        private Label label2;
        private NumericUpDown nudDelaySeconds;
        private Label label4;
        private Label label3;
        private TextBox txbGameName;
        private TextBox txbServerName;
        private Label label5;
        private Button btnDirectory;
        private Button btnDefault;
        private ProgressBar pgbLaunching;
    }
}