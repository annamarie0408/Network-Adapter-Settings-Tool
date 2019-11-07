using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security;


namespace Network_Adapter_Settings_Tool__Win_10_
{
    public partial class MainForm : Form
    {
        string var;
        public MainForm()
        {
            InitializeComponent();
        }
        private void dropDownComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var = dropDownComboBox.Text;
            Console.WriteLine("This is selected" + var);

            if (var == "Ethernet" || var == "Ethernet 2" || var == "Ethernet 3" || var == "Ethernet 4" || var == "Ethernet 5"
                || var == "Wi-Fi" || var == "Wi-Fi 2" || var == "Wi-Fi 3" || var == "Wi-Fi 4" || var == "Wi-Fi 5")
            {
                connectionSelectionBtn.Visible = true;
                connectionSelectionBtn.Text = "Click here to enable " + var;
            }

        }

        private void connectionSelectionBtn_Click(object sender, EventArgs e)
        {
            
            string connection = " \"" + var + "\" ";
            string test = "netsh interface set interface" + connection + "enable";

            var pass = new SecureString();
            //foreach (var c in "") pass.AppendChar(c);  --> Store the users password here
            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd.exe", "/C " + test);
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;            
            procStartInfo.CreateNoWindow = true;
            //procStartInfo.UserName = ""; --Store the users Username here
            procStartInfo.Password = pass;
            procStartInfo.LoadUserProfile = false;
            Process proc = new Process();
            proc.StartInfo = procStartInfo;
            proc.Start();            
            

        }
        
    }
}