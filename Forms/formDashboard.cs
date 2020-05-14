using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Akhir.UserControls;

namespace Tugas_Akhir.Forms
{
    public partial class formDashboard : Form
    {
        public formDashboard()
        {
            InitializeComponent();
            home1.BringToFront();
            labelTitle.Text = "Gunakan Jasa Kami Stay at Home";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
            labelTitle.Text = "Gunakan Jasa Kami Stay at Home";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu1.BringToFront();
            labelTitle.Text = "Pesan Sekarang";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            orderSkut1.BringToFront();
            labelTitle.Text = "skut";
        }
    }
}
