using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UcgenAlanHesaplamaClassOrnegi.Sınıflar;

namespace UcgenAlanHesaplamaClassOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UcgenAlanHesapla ucgen = new UcgenAlanHesapla();

            ucgen._taban = Convert.ToInt32(txtTaban.Text);
            ucgen._yukseklik = Convert.ToInt32(txtYukseklik.Text);

            MessageBox.Show("Alan : " + ucgen.AlanHesabi().ToString());
        }
    }
}
