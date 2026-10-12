using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YasanilabilirSicaklikHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtSicaklik.Text) >= 20 && Convert.ToInt32(txtSicaklik.Text) <= 26)
            {
                MessageBox.Show("Yaşanabilir sıcaklık aralığındasınız.");
            }
            else
            {
                MessageBox.Show("Yaşanabilir sıcaklık aralığında değilsiniz.");
            }
        }
    }
}
