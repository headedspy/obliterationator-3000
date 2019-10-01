using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetupApp{
    public partial class Form1 : Form{

        public Form1(){
            InitializeComponent();
        }

        String mStr = "";
        bool login = false;

        private void Form_Load(object sender, EventArgs e){
            serialPort.Open();
            timer.Start();
        }

        ~Form1(){
            serialPort.Close();
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e){
            output.Text = mStr;
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
            } else if (mStr.Equals("LI\r")) {
                OutputText("Password incorrect");
            } else if (mStr.Equals("PC\r")) {
                OutputText("Password successfully changed");
                ClearBox(input);
            }
        }

        private void changePassButton_Click(object sender, EventArgs e){
            String serialData = "P " + input.Text;
            //password; staticIP; SSID/pass
            serialPort.WriteLine(serialData);
        }

        private void passwordButton_Click(object sender, EventArgs e){
            String serialData = "C " + passwordBox.Text;
            serialPort.WriteLine(serialData);
        }

        private void logoutButton_Click(object sender, EventArgs e){
            login = false;
            LoginControl();
        }

        private void wifiButton_Click(object sender, EventArgs e)
        {
            String ssid = wifiSsidBox.Text;
            String pass = wifiPassBox.Text;

            String serialData = "W " + ssid;

            serialPort.WriteLine(serialData);

            serialData = "w " + pass;

            serialPort.WriteLine(serialData);
        }

        delegate void SetTextCallback(string text);
        delegate void LoginControlCallback();
        delegate void ClearBoxCallback(TextBox box);

        private void OutputText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (appOutput.InvokeRequired) {
                SetTextCallback d = new SetTextCallback(OutputText);
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
    }
}
