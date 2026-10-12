using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevUygulama16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double turkceDogru, matDogru;
            double turkceYanlis, matYanlis;
            double turkceNet, matNet;
            turkceDogru = Convert.ToDouble(txtTurkceDogru.Text);
            turkceYanlis = Convert.ToDouble(txtTurkceYanlis.Text);
            turkceNet = (turkceDogru - (turkceYanlis / 4));
            txtTurkceNet.Text = turkceNet.ToString("0.00");
            matDogru = Convert.ToDouble(txtMatematikDogru.Text);
            matYanlis = Convert.ToDouble(txtMatematikYanlis.Text);
            matNet = (matDogru - (matYanlis / 4));
            txtMatematikNet.Text = matNet.ToString("0.00");
        }
    }
}
