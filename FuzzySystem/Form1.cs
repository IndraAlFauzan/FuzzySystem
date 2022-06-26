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
            double rpb = Math.Round(pb, 2);
            double ps = Convert.ToInt32(tbPermintaanSedikit.Text);
            double rps = Math.Round(ps, 2);
            double sb = Convert.ToInt32(tbStokBanyak.Text);
            double rsb = Math.Round(sb, 2);
            double ss = Convert.ToInt32(tbStokSedikit.Text);
            double rss = Math.Round(ss, 2);
            double permintaan = Convert.ToInt32(tbPermintaan.Text);
            double stok = Convert.ToInt32(tbStock.Text);
            

            //Menghitung Fuzzifikasi
            //permintaan
            double μPermintaanRendah = Math.Round((rpb - permintaan) / (rpb - rps),2);
            double μPermintaanTinggi = Math.Round((permintaan - rps) / (rpb - rps),2);
            //stok
            double μStockRendah = Math.Round((rsb - stok) / (rsb - rss),2);
            double μStockTinggi = Math.Round((stok - ss) / (rsb - rss),2);

            //inferensi
            double p1 = Math.Min(μStockTinggi,μPermintaanTinggi );
            double z1 = Math.Round((p1 * (rsb - rpb)) + rpb,2);

            double p2 = Math.Min(μStockTinggi, μPermintaanRendah);
            double z2 = Math.Round((p2 * (rsb - rpb)) + rpb,2);

            double p3 = Math.Min(μStockRendah, μPermintaanTinggi);
            double z3 = Math.Round((p3 * (rsb - rpb)) - sb * -1,2);

            double p4 = Math.Min(μStockRendah, μPermintaanRendah);
            double z4 = Math.Round((p4 * (rsb - rpb)) - sb * -1,2);

            //defuzzyfikasi
            hasil = Math.Round(((p1 * z1) + (p2 * z2) + (p3 * z3) + (p4 * z4)) / p1 + p2 + p3 + p4);

            lbHasil.Text = hasil.ToString();

            lbPB.Text = pb.ToString();
            lbPS.Text = ps.ToString();
            lbSB.Text = sb.ToString();
            lbSS.Text = ss.ToString();
            lbPermintaan.Text = permintaan.ToString();
            lbStock.Text = stok.ToString();

            tbPemintaanBanyak.Clear();
            tbPermintaan.Clear();
            tbPermintaanSedikit.Clear();
            tbStock.Clear();
            tbStokBanyak.Clear();
            tbStokSedikit.Clear();

        }
        
    }
}
