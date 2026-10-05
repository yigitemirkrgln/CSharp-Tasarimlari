using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevUygulama13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBirinciOrnekKod_Click(object sender, EventArgs e)
        {
            string ad, soyad, topla;
            ad = "Yiğit";
            soyad = "Karaoğlan";
            topla = ad + " " + soyad;
            MessageBox.Show(topla);
        }

        private void btnIkıncıOrnekKod_Click(object sender, EventArgs e)
        {
            txtBir.Text = "25";
            txtIkı.Text = "2";
            txtUc.Text = txtBir.Text + txtIkı.Text;
        }

        private void txtIkı_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
