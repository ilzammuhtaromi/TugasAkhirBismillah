using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Akhir.Forms;

namespace Tugas_Akhir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            formDashboard obj = new formDashboard();
            obj.Show();
            this.Hide();
        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if(txtUsername.Text.Equals(@"User Name"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = @"User Name";
            }
        }

        private void txtPasswordEnter(object sender, EventArgs e)
        {
            if(txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
            }

        }

        private void txtPasswordLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Password";
            }
        }
    }
}
