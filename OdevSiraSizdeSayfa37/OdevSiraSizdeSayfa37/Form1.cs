using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OdevSiraSizdeSayfa37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaresiniAl_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtGiris.Text);
            double kare = sayi * sayi;

            MessageBox.Show("Sayının karesi: " + kare);
        }
    }
}
