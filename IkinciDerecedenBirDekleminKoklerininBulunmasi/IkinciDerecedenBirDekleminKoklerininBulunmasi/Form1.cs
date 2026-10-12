using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IkinciDerecedenBirDekleminKoklerininBulunmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double c = Convert.ToDouble(txtC.Text);

            if (a == 0)
            {
                MessageBox.Show("a değeri 0 olamaz.");
                return;
            }

            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                MessageBox.Show("Denklemin gerçek kökü yok.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                MessageBox.Show("Çakışık kök: " + x);
            }
            else
            {
                double karekok = 0;

               
                while ((karekok + 1) * (karekok + 1) <= delta)
                {
                    karekok++;
                }

                double x1 = (-b + karekok) / (2 * a);
                double x2 = (-b - karekok) / (2 * a);

                MessageBox.Show("Yaklaşık kökler:\nx1 = " + x1 + "\nx2 = " + x2);
            }
        }
    }
}
