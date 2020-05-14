using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Akhir.UserControls
{
    public partial class orderSkut : UserControl
    {
        public orderSkut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bptehAnget, bpbuburKacang, bpkolek, bpesBuah, bpgorengan, bppaheNasi,  bpongkir, bptotalHarga;
            double hargaTa, hargaBk, hargaK, hargaEb, hargaG, hargaPn, bptotalpembayaran;

            bptehAnget = double.Parse(tehAnget.Text);
            bpbuburKacang = double.Parse(buburKacang.Text);
            bpkolek = double.Parse(kolek.Text);
            bpesBuah = double.Parse(esBuah.Text);
            bpgorengan = double.Parse(gorengan.Text);
            bppaheNasi = double.Parse(paheNasi.Text);
           
            hargaTa = bptehAnget * 3000;
            hargaBk = bpbuburKacang * 5000;
            hargaK = bpkolek * 4000;
            hargaEb = bpesBuah * 5000;
            hargaG = bpgorengan * 1000;
            hargaPn = bppaheNasi * 15000;

            bptotalHarga = hargaTa + hargaBk + hargaK + hargaEb + hargaG + hargaPn;
            bpongkir = bptotalHarga * 0.05;

            bptotalpembayaran = bptotalHarga + bpongkir;
            
            totalHarga.Text = "Rp." + bptotalHarga.ToString("N");
            ongkir.Text = "Rp." + bpongkir.ToString("N");
            totalPembayaran.Text = "Rp." + bptotalpembayaran.ToString("N");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Pesanan anda segera diantar", "Terimakasih telah menggunakan jasa kami", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)

            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tujuan tujuanObject = new Tujuan();
            tujuanObject.Name = txtName.Text;
            tujuanObject.Address = txtAdress.Text;

            listBoxCek.Items.Add(tujuanObject.Name);
            listBoxCek.Items.Add(tujuanObject.Address);
        }
    }
}
