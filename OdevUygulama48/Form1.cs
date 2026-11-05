using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevUygulama48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKareAl_Click(object sender, EventArgs e)
        {
            int sayi1, sayinin_karesi;

            try
            {
                sayi1 = Convert.ToInt32(txtKare.Text);
                sayinin_karesi = sayi1 * sayi1;
                MessageBox.Show("Sayının Karesi : " + sayinin_karesi.ToString(), "İŞLEM TAMAMLANDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!", "HATA TESPİT EDİLDİ",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Hata olsa bile çalışacak kodlar
            }
        }
    }
}
