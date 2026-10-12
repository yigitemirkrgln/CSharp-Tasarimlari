using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AldigiNotBasariHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int basari;
            if (Convert.ToInt32(txtNot.Text) >= 0 && Convert.ToInt32(txtNot.Text) <= 44)
            {
                basari = 1;
                MessageBox.Show("Başarı Notunuz: " + basari + " (Başarısız)");
            }
            else if (Convert.ToInt32(txtNot.Text) >= 45 && Convert.ToInt32(txtNot.Text) <= 54)
            {
                basari = 3;
                MessageBox.Show("Başarı Notunuz: " + basari + " (Geçer)");
            }
            else if (Convert.ToInt32(txtNot.Text) >= 55 && Convert.ToInt32(txtNot.Text) <= 69)
            {
                basari = 3;
                MessageBox.Show("Başarı Notunuz: " + basari + " (Orta)");
            }
            else if (Convert.ToInt32(txtNot.Text) >= 70 && Convert.ToInt32(txtNot.Text) <= 84)
            {
                basari = 4;
                MessageBox.Show("Başarı Notunuz: " + basari + " (İyi)");
            }
            else if (Convert.ToInt32(txtNot.Text) >= 85 && Convert.ToInt32(txtNot.Text) <= 100)
            {
                basari = 5;
                MessageBox.Show("Başarı Notunuz: " + basari + " (Pekiyi)");
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir not giriniz.");
            }
        }
    }
}
