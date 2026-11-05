using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevListboxSayac
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        bool durum = true;
        private void btnAktar_Click(object sender, EventArgs e)
        {
            if (durum)
            {
                for (int sayi = 0; sayi < lbBir.Items.Count; sayi++)
                {
                    lbIki.Items.Add(lbBir.Items[sayi]);
                }
                durum = false;
            }
            else
            {
                for (int sayi = 0; sayi < lbBir.Items.Count; sayi++)
                {
                    cmbIsimler.Items.Add(lbBir.Items[sayi]);
                }
                durum = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad;
            ad = txtGiris.Text;
            lbBir.Items.Add(txtGiris.Text.ToUpper());
            txtGiris.Clear();
        }
    }
}
