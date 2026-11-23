using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alan_Hesabı_Class_Örneği.Sınıflar;

namespace Alan_Hesabı_Class_Örneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            DikdortgenAlan alan = new DikdortgenAlan();

            alan.KisaKenar = Convert.ToInt32(txtSayiBir.Text);
            alan.UzunKenar = Convert.ToInt32(txtSayiIki.Text);

            MessageBox.Show("Alan : " + alan.AlanHesapla().ToString());
        }
    }
}
