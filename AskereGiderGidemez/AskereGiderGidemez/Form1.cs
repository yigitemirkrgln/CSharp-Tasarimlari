using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AskereGiderGidemez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int yas = Convert.ToInt32(txtYas.Text);
            string cinsiyet = txtCinsiyet.Text.ToUpper();

            if (cinsiyet == "E" && yas > 20)
            {
                MessageBox.Show("Askere Gidebilir");
            }
            else
            {
                MessageBox.Show("Askere Gidemez");
            }
        }
    }
}
