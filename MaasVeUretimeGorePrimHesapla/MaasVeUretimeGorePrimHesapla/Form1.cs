using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaasVeUretimeGorePrimHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int maas = Convert.ToInt32(txtMaas.Text);
            int parca = Convert.ToInt32(txtUretilenUrun.Text);
            int prim = 0;

            if (parca >= 1 && parca <= 10)
            {
                prim = parca * 5;
            }
            else if (parca >= 11 && parca <= 25)
            {
                prim = parca * 11;
            }
            else if (parca >= 26 && parca <= 40)
            {
                prim = parca * 17;
            }
            else if (parca >= 41)
            {
                prim = parca * 30;
            }
            int toplamUcret = maas + prim;
            MessageBox.Show("Toplam Maaş : " + toplamUcret + " TL");
        }
    }
}
