using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace SetupApp{
    public partial class Form1 : Form{

        public Form1(){
            InitializeComponent();
        }

        String mStr = "";
        bool login = false;

        private void Form_Load(object sender, EventArgs e){
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports) serialPorts.Items.Add(port);
        }

        ~Form1(){
            serialPort.Close();
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e){
            mStr = serialPort.ReadLine();

            if (mStr.Equals("LA\r")) {
                OutputText("Login accepted");
                ClearBox(passwordBox);
                login = true;
                LoginControl();
            } else if (mStr.Equals("LR\r")) {
                OutputText("Password change refused");
            } else if (mStr.Contains("LI\r")) {
                OutputText("Password incorrect");
            } else if (mStr.Contains("PC")) {
                OutputText("Password successfully changed");
                ClearBox(input);
            }else if (mStr.Equals("WI\r")) {
                wifiStatusPanel.BackColor = Color.Green;
            } else if (mStr.Equals("WO\r")) {
                wifiStatusPanel.BackColor = Color.Red;
            }else if (mStr.Length != 0 && mStr[0] == 'I') {
                ChangeIP(mStr.Substring(1));
            }
            else {
                OutputText(mStr);
            }
        }

        private void changePassButton_Click(object sender, EventArgs e){
            String serialData = "P " + input.Text;
            try {
                serialPort.WriteLine(serialData);
            } catch (System.InvalidOperationException) {
                OutputText("Connection to port refused");
            }
        }

        private void passwordButton_Click(object sender, EventArgs e){
            String serialData = "C " + passwordBox.Text;
            try {
                serialPort.WriteLine(serialData);
            } catch (System.InvalidOperationException) {
                OutputText("Connection to port refused");
            }
        }

        private void logoutButton_Click(object sender, EventArgs e){
            login = false;
            LoginControl();
        }

        private void wifiButton_Click(object sender, EventArgs e){
            String ssid = wifiSsidBox.Text;
            String pass = wifiPassBox.Text;

            String serialData = "W " + ssid + "/" + pass;

            try {
                serialPort.WriteLine(serialData);
            } catch (System.InvalidOperationException) {
                OutputText("Connection to port refused");
            }
        }

        delegate void OutputTextCallback(string text);
        delegate void LoginControlCallback();
        delegate void ClearBoxCallback(TextBox box);
        delegate void ChangeIPCallback(string ip);

        private void OutputText(string text){
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (appOutput.InvokeRequired) {
                OutputTextCallback d = new OutputTextCallback(OutputText);
                Invoke(d, new object[] { text });
            }else {
                appOutput.Text = text;
            }
        }

        private void LoginControl(){
            if (loginPanel.InvokeRequired) {
                LoginControlCallback d = new LoginControlCallback(LoginControl);
                Invoke(d, new object[] {});
            }else{
                loginPanel.Visible = !login;
            }
        }

        private void ClearBox(TextBox box){
            if (box.InvokeRequired) {
                ClearBoxCallback d = new ClearBoxCallback(ClearBox);
                Invoke(d, new object[] { box });
            }else {
                box.Text = "";
            }
        }

        private void ChangeIP(string ip){
            if (ipLabel.InvokeRequired) {
                ChangeIPCallback d = new ChangeIPCallback(ChangeIP);
                Invoke(d, new object[] { ip });
            } else {
                ipLabel.Text = ip;
            }
        }

        private void serialPorts_SelectedIndexChanged(object sender, EventArgs e){
            serialPort.Close();
            serialPort.PortName = serialPorts.SelectedItem.ToString();
        }

        private void portConnectButton_Click(object sender, EventArgs e){
            try {
                serialPort.Open();
            } catch (System.IO.IOException) {
                OutputText("Can't connect to port");
            } catch (InvalidOperationException) {
                OutputText("Port already open");
            } catch (UnauthorizedAccessException) {
                OutputText("Access to port refused");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e){
            serialPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();

            foreach(string port in ports) serialPorts.Items.Add(port);
        }

        private void showPassButton_Click(object sender, EventArgs e){
            wifiPassBox.PasswordChar = (wifiPassBox.PasswordChar == '\0' ? '*' : '\0');
        }

        private void showLoginPassButton_Click(object sender, EventArgs e){
            passwordBox.PasswordChar = (passwordBox.PasswordChar == '\0' ? '*' : '\0');
        }

        private void entryButton_Click(object sender, EventArgs e){
            try {
                serialPort.WriteLine("E"+entryTextBox.Text);
            } catch (System.InvalidOperationException) {
                OutputText("Connection to port refused");
            }
        }

        private void exitButton_Click(object sender, EventArgs e){
            try {
                serialPort.WriteLine("e" + exitTextBox.Text);
            } catch (System.InvalidOperationException) {
                OutputText("Connection to port refused");
            }
        }
    }
}
