using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sadece5Veya3Bolunme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSayi.Text);

            if (sayi % 5 == 0 && sayi % 3 == 0)
            {
                int toplam = 0;

                for (; sayi > 0; sayi = sayi / 10)
                {
                    toplam = toplam + sayi % 10;
                }

               MessageBox.Show("Sayı hem 5'e hem 3'e bölünüyor. Rakamları toplamı: " + toplam);
            }
            else
            {
               MessageBox.Show("Sayı 5'e veya 3'e bölünmüyor.");
            }
        }
    }
}
