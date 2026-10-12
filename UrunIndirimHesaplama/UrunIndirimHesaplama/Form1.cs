using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunIndirimHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal fiyat1 = Convert.ToDecimal(txtUrun1.Text);
            decimal fiyat2 = Convert.ToDecimal(txtUrun2.Text);

            if (fiyat1 > 100)
            {
                fiyat2 = fiyat2 * 0.75m;
            }

            decimal toplam = fiyat1 + fiyat2;

            MessageBox.Show("Toplam fiyat: " + toplam + " TL");
        }
    }
}
