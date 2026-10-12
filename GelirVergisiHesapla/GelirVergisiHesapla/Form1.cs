using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GelirVergisiHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal gelir = Convert.ToDecimal(txtGelir.Text);
            decimal vergiOrani;

            if (gelir <= 150000000)
            {
                vergiOrani = 0.25m;
            }
            else if (gelir <= 300000000)
            {
                vergiOrani = 0.30m;
            }
            else if (gelir <= 600000000)
            {
                vergiOrani = 0.35m;
            }
            else if (gelir <= 1200000000)
            {
                vergiOrani = 0.40m;
            }
            else
            {
                vergiOrani = 0.50m;
            }

            decimal vergi = gelir * vergiOrani;

            MessageBox.Show("Vergi: " + vergi + " TL");
        }
    }
}
