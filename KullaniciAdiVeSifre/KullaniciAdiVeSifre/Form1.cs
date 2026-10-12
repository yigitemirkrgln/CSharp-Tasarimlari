using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciAdiVeSifre
{
    public partial class Form1 : Form
    {
        int yanlisSayisi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
           

            if (txtKullaniciAdi.Text == "admin" && txtSifre.Text == "1234")
            {
                MessageBox.Show("Giriş başarılı.");
                this.Close();
            }
            else
            {
                yanlisSayisi++;

                if (yanlisSayisi == 3)
                {
                    MessageBox.Show("Üç kez yanlış girdiniz. Program sonlanıyor.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                }
            }
        }
    }
}
