using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerstenGectiKaldiHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtNot.Text) >= 50)
            {
               MessageBox.Show("Tebrikler, dersten geçtiniz!");
            }
            else
            {
                MessageBox.Show("Üzgünüz, dersten kaldınız.");
            }
        }
    }
}
