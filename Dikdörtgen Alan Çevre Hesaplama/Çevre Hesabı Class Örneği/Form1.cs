using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Çevre_Hesabı_Class_Örneği.Sınıflar;

namespace Çevre_Hesabı_Class_Örneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Cevrehesabi cevre = new Cevrehesabi();

            cevre.KisaKenar = Convert.ToInt32(txtKisaKenar.Text);
            cevre.UzunKenar = Convert.ToInt32(txtUzunKenar.Text);

            MessageBox.Show("Çevre : " + cevre.Cevre());
        }
    }
}
