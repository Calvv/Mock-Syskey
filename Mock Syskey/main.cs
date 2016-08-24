using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mock_Syskey
{
    public partial class main : Form
    {
        

        public main()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StartupKey f_startupkey = new StartupKey();
            f_startupkey.FormClosed += new FormClosedEventHandler(f_FormClosed);
            f_startupkey.ShowDialog();
        }

        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            System.Threading.Thread.Sleep(3500);
            MessageBox.Show("Credits: Calvv @github.com/Calvv", "Credits: Calvv", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.ExitThread();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
