using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevUygulama49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi;
            long parola;
            try
            {
                kullaniciAdi = txtKullaniciAdi.Text.ToString();
                parola = long.Parse(txtParola.Text.ToString());
                MessageBox.Show("Giriş Başarılı. Hoşgeldiniz, " + kullaniciAdi,"Giriş Onaylandı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Şifreniz Sadece Sayılardan Oluşmalıdır. Tekrar Deneyiniz.","Yanlış Giriş Algılandı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtParola.Text = "";
            }
            finally
            {

            }
        }
    }
}
