using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzacıUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int pizzaAdet = Convert.ToInt32(txtPizzaAdet.Text);
            int icecekAdet = Convert.ToInt32(txtIcecekAdet.Text);
            int tatliAdet = Convert.ToInt32(txtTatliAdet.Text);

            int pizzaToplam = 150 * pizzaAdet;
            int icecekToplam = 40 * icecekAdet;
            int tatliToplam = 60 * tatliAdet;

            int genelToplam = pizzaToplam + icecekToplam + tatliToplam;

            txtPizzaToplam.Text = "Pizza toplamı: " + pizzaToplam + " TL\n";
            txtIcecekToplam.Text = "İçecek toplamı: " + icecekToplam + " TL\n";
            txtTatliToplam.Text = "Tatlı toplamı: " + tatliToplam + " TL\n";
            txtToplamTutar.Text = "Genel toplam: " + genelToplam + " TL";
        }
    }
}
