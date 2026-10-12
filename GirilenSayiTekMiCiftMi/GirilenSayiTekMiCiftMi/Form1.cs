using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirilenSayiTekMiCiftMi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtSayiGir.Text) % 2 == 0)
            {
                MessageBox.Show("Girilen sayı çifttir.");
            }
            else
            {
                MessageBox.Show("Girilen sayı tektir.");
            }
        }
    }
}
