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
            } else if (mStr.Equals("LR\r")) {
                OutputText("Login refused");
            } else if (mStr.Equals("LI\r")) {
                OutputText("Login incorrect");
            } else if (mStr.Equals("PC\r")) {
                OutputText("Password changed");
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

        delegate void SetTextCallback(string text);

        private void OutputText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.appOutput.InvokeRequired) {
                SetTextCallback d = new SetTextCallback(OutputText);
                this.Invoke(d, new object[] { text });
            } else {
                this.appOutput.Text = text;
            }
        }
    }
}
