using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BolmeIslemiProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtBolunen.Text);
            int sayi2 = Convert.ToInt32(txtBolen.Text);

            if (sayi2 == 0)
            {
                MessageBox.Show("Sıfıra bölme yapılamaz.");
            }
            else
            {
                int sonuc = sayi1 / sayi2;
                MessageBox.Show("Sonuç: " + sonuc.ToString());
            }
        }
    }
}
