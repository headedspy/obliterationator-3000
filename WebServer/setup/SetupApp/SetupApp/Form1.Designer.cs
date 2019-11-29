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
            this.input = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.showLoginPassButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.portConnectButton = new System.Windows.Forms.Button();
            this.serialPorts = new System.Windows.Forms.ComboBox();
            this.appOutput = new System.Windows.Forms.Label();
            this.NetworkBox = new System.Windows.Forms.GroupBox();
            this.showPassButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wifiButton = new System.Windows.Forms.Button();
            this.wifiPassBox = new System.Windows.Forms.TextBox();
            this.wifiSsidBox = new System.Windows.Forms.TextBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.wifiStatusPanel = new System.Windows.Forms.Panel();
            this.ipLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.entryTextBox = new System.Windows.Forms.TextBox();
            this.exitTextBox = new System.Windows.Forms.TextBox();
            this.entryButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.NetworkBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // input
            // 
            this.input.Location = new System.Drawing.Point(6, 19);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 2;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(167, 119);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
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
            this.passwordButton.Text = "Login";
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
            this.loginPanel.Controls.Add(this.showLoginPassButton);
            this.loginPanel.Controls.Add(this.refreshButton);
            this.loginPanel.Controls.Add(this.portConnectButton);
            this.loginPanel.Controls.Add(this.serialPorts);
            this.loginPanel.Controls.Add(this.passwordButton);
            this.loginPanel.Controls.Add(this.passwordBox);
            this.loginPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginPanel.Location = new System.Drawing.Point(32, 12);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(444, 313);
            this.loginPanel.TabIndex = 6;
            // 
            // showLoginPassButton
            // 
            this.showLoginPassButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showLoginPassButton.Location = new System.Drawing.Point(273, 119);
            this.showLoginPassButton.Name = "showLoginPassButton";
            this.showLoginPassButton.Size = new System.Drawing.Size(46, 20);
            this.showLoginPassButton.TabIndex = 6;
            this.showLoginPassButton.Text = "Show";
            this.showLoginPassButton.UseVisualStyleBackColor = true;
            this.showLoginPassButton.Click += new System.EventHandler(this.showLoginPassButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.refreshButton.Location = new System.Drawing.Point(181, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // portConnectButton
            // 
            this.portConnectButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.portConnectButton.Location = new System.Drawing.Point(262, 12);
            this.portConnectButton.Name = "portConnectButton";
            this.portConnectButton.Size = new System.Drawing.Size(75, 23);
            this.portConnectButton.TabIndex = 6;
            this.portConnectButton.Text = "Connect";
            this.portConnectButton.UseVisualStyleBackColor = true;
            this.portConnectButton.Click += new System.EventHandler(this.portConnectButton_Click);
            // 
            // serialPorts
            // 
            this.serialPorts.FormattingEnabled = true;
            this.serialPorts.Location = new System.Drawing.Point(52, 12);
            this.serialPorts.Name = "serialPorts";
            this.serialPorts.Size = new System.Drawing.Size(121, 21);
            this.serialPorts.TabIndex = 5;
            this.serialPorts.SelectedIndexChanged += new System.EventHandler(this.serialPorts_SelectedIndexChanged);
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
            this.NetworkBox.Controls.Add(this.showPassButton);
            this.NetworkBox.Controls.Add(this.label2);
            this.NetworkBox.Controls.Add(this.label1);
            this.NetworkBox.Controls.Add(this.wifiButton);
            this.NetworkBox.Controls.Add(this.wifiPassBox);
            this.NetworkBox.Controls.Add(this.wifiSsidBox);
            this.NetworkBox.Location = new System.Drawing.Point(64, 60);
            this.NetworkBox.Name = "NetworkBox";
            this.NetworkBox.Size = new System.Drawing.Size(251, 105);
            this.NetworkBox.TabIndex = 8;
            this.NetworkBox.TabStop = false;
            this.NetworkBox.Text = "Network";
            // 
            // showPassButton
            // 
            this.showPassButton.Location = new System.Drawing.Point(196, 45);
            this.showPassButton.Name = "showPassButton";
            this.showPassButton.Size = new System.Drawing.Size(46, 20);
            this.showPassButton.TabIndex = 5;
            this.showPassButton.Text = "Show";
            this.showPassButton.UseVisualStyleBackColor = true;
            this.showPassButton.Click += new System.EventHandler(this.showPassButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pass:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SSID:";
            // 
            // wifiButton
            // 
            this.wifiButton.Location = new System.Drawing.Point(86, 71);
            this.wifiButton.Name = "wifiButton";
            this.wifiButton.Size = new System.Drawing.Size(75, 23);
            this.wifiButton.TabIndex = 2;
            this.wifiButton.Text = "Connect";
            this.wifiButton.UseVisualStyleBackColor = true;
            this.wifiButton.Click += new System.EventHandler(this.wifiButton_Click);
            // 
            // wifiPassBox
            // 
            this.wifiPassBox.Location = new System.Drawing.Point(50, 45);
            this.wifiPassBox.Name = "wifiPassBox";
            this.wifiPassBox.PasswordChar = '*';
            this.wifiPassBox.Size = new System.Drawing.Size(140, 20);
            this.wifiPassBox.TabIndex = 1;
            // 
            // wifiSsidBox
            // 
            this.wifiSsidBox.Location = new System.Drawing.Point(50, 19);
            this.wifiSsidBox.Name = "wifiSsidBox";
            this.wifiSsidBox.Size = new System.Drawing.Size(140, 20);
            this.wifiSsidBox.TabIndex = 0;
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
            // wifiStatusPanel
            // 
            this.wifiStatusPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.wifiStatusPanel.Location = new System.Drawing.Point(478, 342);
            this.wifiStatusPanel.Name = "wifiStatusPanel";
            this.wifiStatusPanel.Size = new System.Drawing.Size(32, 30);
            this.wifiStatusPanel.TabIndex = 10;
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ipLabel.Location = new System.Drawing.Point(332, 347);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(124, 20);
            this.ipLabel.TabIndex = 6;
            this.ipLabel.Text = "000.000.00.00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exitButton);
            this.groupBox2.Controls.Add(this.entryButton);
            this.groupBox2.Controls.Add(this.exitTextBox);
            this.groupBox2.Controls.Add(this.entryTextBox);
            this.groupBox2.Location = new System.Drawing.Point(64, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 99);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensor Threshold";
            // 
            // entryTextBox
            // 
            this.entryTextBox.Location = new System.Drawing.Point(6, 19);
            this.entryTextBox.Name = "entryTextBox";
            this.entryTextBox.Size = new System.Drawing.Size(100, 20);
            this.entryTextBox.TabIndex = 0;
            // 
            // exitTextBox
            // 
            this.exitTextBox.Location = new System.Drawing.Point(6, 73);
            this.exitTextBox.Name = "exitTextBox";
            this.exitTextBox.Size = new System.Drawing.Size(100, 20);
            this.exitTextBox.TabIndex = 1;
            // 
            // entryButton
            // 
            this.entryButton.Location = new System.Drawing.Point(112, 16);
            this.entryButton.Name = "entryButton";
            this.entryButton.Size = new System.Drawing.Size(129, 23);
            this.entryButton.TabIndex = 2;
            this.entryButton.Text = "Update entry sensor";
            this.entryButton.UseVisualStyleBackColor = true;
            this.entryButton.Click += new System.EventHandler(this.entryButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(112, 70);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(129, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Update exit sensor";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(755, 419);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.wifiStatusPanel);
            this.Controls.Add(this.NetworkBox);
            this.Controls.Add(this.appOutput);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button changePassButton;
        private System.Windows.Forms.TextBox input;
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
        private System.Windows.Forms.ComboBox serialPorts;
        private System.Windows.Forms.Button portConnectButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button showPassButton;
        private System.Windows.Forms.Button showLoginPassButton;
        private System.Windows.Forms.Label ipLabel;
        protected System.Windows.Forms.Panel wifiStatusPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button entryButton;
        private System.Windows.Forms.TextBox exitTextBox;
        private System.Windows.Forms.TextBox entryTextBox;
    }
}

