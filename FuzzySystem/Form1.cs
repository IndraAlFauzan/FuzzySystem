using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzySystem
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btHitung_Click(object sender, EventArgs e)
        {

            double hasil;
            double pb = Convert.ToInt32(tbPemintaanBanyak.Text) ;
            double ps = Convert.ToInt32(tbPermintaanSedikit.Text);
            double sb = Convert.ToInt32(tbStokBanyak.Text);
            double ss = Convert.ToInt32(tbStokSedikit.Text);
            double permintaan = Convert.ToInt32(tbPermintaan.Text);
            double stok = Convert.ToInt32(tbStock.Text);
            

            //Menghitung Fuzzifikasi
            //permintaan
            double μPermintaanRendah = (pb - permintaan) / (pb - ps);
            double μPermintaanTinggi = (permintaan - ps) / (pb - ps);
            //stok
            double μStockRendah = (sb - stok) / (sb - ss);
            double μStockTinggi = (stok - ss) / (sb - ss);

            //inferensi
            double p1 = Math.Min(μStockTinggi,μPermintaanTinggi );
            double z1 = (p1 * (sb - pb)) + pb;

            double p2 = Math.Min(μStockTinggi, μPermintaanRendah);
            double z2 = (p2 * (sb - pb)) + pb;

            double p3 = Math.Min(μStockRendah, μPermintaanTinggi);
            double z3 = (p3 * (sb - pb)) - sb * -1;

            double p4 = Math.Min(μStockRendah, μPermintaanRendah);
            double z4 = (p4 * (sb - pb)) - sb * -1;

            //defuzzyfikasi
            hasil = ((p1 * z1) + (p2 * z2) + (p3 * z3) + (p4 * z4)) / p1 + p2 + p3 + p4;

            lbHasil.Text = hasil.ToString();

        }
        
    }
}
