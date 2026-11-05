using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevIkinciSiraSizdeSayfa66
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int i = 0;

            while (i < 20)
            {
                toplam = toplam + Convert.ToInt32(lbSayilar.Items[i]); 
                i++;
            }

            
            MessageBox.Show("Toplam: " + toplam,"Hesaplandı",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
