using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcgenOlusurOlusmazHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text);
            int c = Convert.ToInt32(txtC.Text);

            if (a > 0 && b > 0 && c > 0 &&
                a + b > c && a + c > b && b + c > a)
            {
                MessageBox.Show("Üçgen oluşturur.");
            }
            else
            {
                MessageBox.Show("Üçgen oluşturmaz.");
            }
        }
    }
}
