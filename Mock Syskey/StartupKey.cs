using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Mock_Syskey
{
    public partial class StartupKey : Form
    {


        public StartupKey()
        {
            InitializeComponent();
            
        }

        private void StartupKey_Load(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void rbSGP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSGP.Checked)
            {

                gbSGP.Enabled = true;
                gbPS.Enabled = false;
            }
            else
            {

                gbSGP.Enabled = false;
                gbPS.Enabled = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Account Database Startup Key was changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string Password = "pwd: " + txtbPassword.Text + Environment.NewLine + "pwd-confirm: " + txtPasswordConfirm.Text;
            Write_Password_To_Appdata(Password);
            this.Visible = false;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Write_Password_To_Appdata(string pwd)
        {
            string Dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MockSyskey-pwd.txt";
            System.IO.File.WriteAllText(Dir, pwd);
        }

        private void StartupKey_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
