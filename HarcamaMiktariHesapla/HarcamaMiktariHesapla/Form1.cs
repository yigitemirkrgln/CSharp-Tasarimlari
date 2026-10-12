using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarcamaMiktariHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtHarcama.Text) > 150)
            {
                MessageBox.Show("Harcama Sonucunuz Normalin Üstündedir.");
            }
            else
            {
                MessageBox.Show("Harcama Sonucunuz Normaldir.");
            }
        }
    }
}
