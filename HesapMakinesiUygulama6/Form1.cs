using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesiUygulama6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBir_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void btnIki_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void btnUc_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void btnDort_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void btnBes_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void btnAlti_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void btnYedi_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void grbTusEkrani_Enter(object sender, EventArgs e)
        {

        }

        private void btnSekiz_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void btnDokuz_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }
        char isaret;
        int sayi_1;
        int sayi_2;
        private void btnTopla_Click(object sender, EventArgs e)
        {
            isaret = '+';
            sayi_1 = Convert.ToInt32(label1.Text);
            label1.Text = "";
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            sayi_2 = Convert.ToInt32(label1.Text);
            if (isaret == '+')
            {
                label1.Text = (sayi_1 + sayi_2).ToString();
            }
            else if (isaret == '-')
            {
                label1.Text = (sayi_1 - sayi_2).ToString();
            }
            else if (isaret == '*')
            {
                label1.Text = (sayi_1 * sayi_2).ToString();
            }
            else if (isaret == '/')
            {
                label1.Text = (sayi_1 / sayi_2).ToString();
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            sayi_1 = 0;
            sayi_2 = 0;
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            isaret = '-';
            sayi_1 = Convert.ToInt32(label1.Text);
            label1.Text = "";

        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            isaret = '*';
            sayi_1 = Convert.ToInt32(label1.Text);
            label1.Text = "";
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            isaret = '/';
            sayi_1 = Convert.ToInt32(label1.Text);
            label1.Text = "";
        }

        private void btnBir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (label1.Text == "0")
                    label1.Text = e.KeyChar.ToString();
                else
                    label1.Text += e.KeyChar;
            }
        }

        private void btnIki_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (label1.Text == "0")
                    label1.Text = e.KeyChar.ToString();
                else
                    label1.Text += e.KeyChar;
            }
        }

        private void btnUc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (label1.Text == "0")
                    label1.Text = e.KeyChar.ToString();
                else
                    label1.Text += e.KeyChar;
            }
        }

        private void btnDort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (label1.Text == "0")
                    label1.Text = e.KeyChar.ToString();
                else
                    label1.Text += e.KeyChar;
            }
        }

        private void btnOn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (label1.Text == "0")
                    label1.Text = e.KeyChar.ToString();
                else
                    label1.Text += e.KeyChar;
            }
        }

        private void btnDokuz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (label1.Text == "0")
                    label1.Text = e.KeyChar.ToString();
                else
                    label1.Text += e.KeyChar;
            }
        }

        private void btnSekiz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (label1.Text == "0")
                    label1.Text = e.KeyChar.ToString();
                else
                    label1.Text += e.KeyChar;
            }
        }

        private void btnYedi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (label1.Text == "0")
                    label1.Text = e.KeyChar.ToString();
                else
                    label1.Text += e.KeyChar;
            }
        }

        private void btnAlti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (label1.Text == "0")
                    label1.Text = e.KeyChar.ToString();
                else
                    label1.Text += e.KeyChar;
            }
        }

        private void btnBes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (label1.Text == "0")
                    label1.Text = e.KeyChar.ToString();
                else
                    label1.Text += e.KeyChar;
            }
        }
    }
}

