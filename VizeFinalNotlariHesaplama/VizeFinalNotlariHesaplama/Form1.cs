using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeFinalNotlariHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double vize = Convert.ToDouble(txtVize.Text);
            double final = Convert.ToDouble(txtFinal.Text);

            double ortalama = (vize + final) / 2;

            MessageBox.Show("Ortalama: " + ortalama);
        }
    }
}
