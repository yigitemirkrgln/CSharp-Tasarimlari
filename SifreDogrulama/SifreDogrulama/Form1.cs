using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreDogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            string dogruSifre = "1234";

            if (txtSifre.Text == dogruSifre)
            {
                MessageBox.Show("Şifre doğru.");
            }
            else
            {
                MessageBox.Show("Şifre yanlış.");
            }
        }
    }
}
