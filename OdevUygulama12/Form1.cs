using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevUygulama12
{
    public partial class Form1 : Form
    {
        int sayi1, sayi2, toplam;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSayi1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSayi2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSayi1.Text, out sayi1) && int.TryParse(txtSayi2.Text, out sayi2))
                if (sayi2 != 0)
                {
                    sayi1 = Convert.ToInt16(txtCarp1.Text);
                    sayi2 = Convert.ToInt16(txtCarp2.Text);
                    toplam = sayi1 * sayi2;
                    txtCarpmaSonuc.Text = toplam.ToString();
                }
                else
                {
                    MessageBox.Show("Bir Sayı Sıfıra Bölünemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            else
            {
                MessageBox.Show("Lütfen boş bırakmayın ve geçerli bir sayı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSayi1.Text, out sayi1) && int.TryParse(txtSayi2.Text, out sayi2))
                if (sayi2 != 0)
                {
                sayi1 = Convert.ToInt16(txtCarp1.Text);
                sayi2 = Convert.ToInt16(txtCarp2.Text);
                toplam = sayi1 * sayi2;
                txtCarpmaSonuc.Text = toplam.ToString();
                }
                else
                {
                    MessageBox.Show("Bir Sayı Sıfıra Bölünemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            else
            {
                MessageBox.Show("Lütfen boş bırakmayın ve geçerli bir sayı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSayi1.Text, out sayi1) && int.TryParse(txtSayi2.Text, out sayi2))

                if (sayi2 != 0)
                {
                    sayi1 = Convert.ToInt16(txtBol1.Text);
                    sayi2 = Convert.ToInt16(txtBol2.Text);
                    toplam = sayi1 / sayi2;
                    txtBolmeSonuc.Text = toplam.ToString();
                }
                else
                {
                    MessageBox.Show("Bir Sayı Sıfıra Bölünemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            else
            {
                MessageBox.Show("Lütfen boş bırakmayın ve geçerli bir sayı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }  
        
    
        private void txtSonuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSayi1.Text, out sayi1) && int.TryParse(txtSayi2.Text, out sayi2))
            {
                sayi1 = Convert.ToInt16(txtSayi1.Text);
                sayi2 = Convert.ToInt16(txtSayi2.Text);
                toplam = sayi1 + sayi2;
                txtSonuc.Text = toplam.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen boş bırakmayın ve geçerli bir sayı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
