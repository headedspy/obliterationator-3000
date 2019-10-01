namespace SetupApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.changePassButton = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.appOutput = new System.Windows.Forms.Label();
            this.NetworkBox = new System.Windows.Forms.GroupBox();
            this.wifiSsidBox = new System.Windows.Forms.TextBox();
            this.wifiPassBox = new System.Windows.Forms.TextBox();
            this.wifiButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.NetworkBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM6";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // changePassButton
            // 
            this.changePassButton.Location = new System.Drawing.Point(112, 19);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(89, 23);
            this.changePassButton.TabIndex = 0;
            this.changePassButton.Text = "Set password";
            this.changePassButton.UseVisualStyleBackColor = true;
            this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(462, 9);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(35, 13);
            this.output.TabIndex = 1;
            this.output.Text = "label1";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(6, 19);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(167, 119);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 3;
            // 
            // passwordButton
            // 
            this.passwordButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passwordButton.Location = new System.Drawing.Point(181, 151);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(75, 23);
            this.passwordButton.TabIndex = 4;
            this.passwordButton.Text = "LOGIN";
            this.passwordButton.UseVisualStyleBackColor = true;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.input);
            this.groupBox1.Controls.Add(this.changePassButton);
            this.groupBox1.Location = new System.Drawing.Point(536, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Panel";
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.loginPanel.Controls.Add(this.passwordButton);
            this.loginPanel.Controls.Add(this.passwordBox);
            this.loginPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginPanel.Location = new System.Drawing.Point(12, 9);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(444, 289);
            this.loginPanel.TabIndex = 6;
            // 
            // appOutput
            // 
            this.appOutput.AutoSize = true;
            this.appOutput.Location = new System.Drawing.Point(29, 371);
            this.appOutput.Name = "appOutput";
            this.appOutput.Size = new System.Drawing.Size(0, 13);
            this.appOutput.TabIndex = 7;
            // 
            // NetworkBox
            // 
            this.NetworkBox.Controls.Add(this.label2);
            this.NetworkBox.Controls.Add(this.label1);
            this.NetworkBox.Controls.Add(this.wifiButton);
            this.NetworkBox.Controls.Add(this.wifiPassBox);
            this.NetworkBox.Controls.Add(this.wifiSsidBox);
            this.NetworkBox.Location = new System.Drawing.Point(12, 131);
            this.NetworkBox.Name = "NetworkBox";
            this.NetworkBox.Size = new System.Drawing.Size(200, 140);
            this.NetworkBox.TabIndex = 8;
            this.NetworkBox.TabStop = false;
            this.NetworkBox.Text = "Network";
            // 
            // wifiSsidBox
            // 
            this.wifiSsidBox.Location = new System.Drawing.Point(54, 34);
            this.wifiSsidBox.Name = "wifiSsidBox";
            this.wifiSsidBox.Size = new System.Drawing.Size(140, 20);
            this.wifiSsidBox.TabIndex = 0;
            // 
            // wifiPassBox
            // 
            this.wifiPassBox.Location = new System.Drawing.Point(54, 60);
            this.wifiPassBox.Name = "wifiPassBox";
            this.wifiPassBox.Size = new System.Drawing.Size(140, 20);
            this.wifiPassBox.TabIndex = 1;
            // 
            // wifiButton
            // 
            this.wifiButton.Location = new System.Drawing.Point(54, 98);
            this.wifiButton.Name = "wifiButton";
            this.wifiButton.Size = new System.Drawing.Size(75, 23);
            this.wifiButton.TabIndex = 2;
            this.wifiButton.Text = "CHANGE";
            this.wifiButton.UseVisualStyleBackColor = true;
            this.wifiButton.Click += new System.EventHandler(this.wifiButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SSID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pass:";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(157, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(755, 419);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.NetworkBox);
            this.Controls.Add(this.appOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.logoutButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.NetworkBox.ResumeLayout(false);
            this.NetworkBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button changePassButton;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button passwordButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label appOutput;
        private System.Windows.Forms.GroupBox NetworkBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wifiButton;
        private System.Windows.Forms.TextBox wifiPassBox;
        private System.Windows.Forms.TextBox wifiSsidBox;
        private System.Windows.Forms.Button logoutButton;
    }
}

