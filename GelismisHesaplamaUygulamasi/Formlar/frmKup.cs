using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KareAlanCevreClass.Sınıflar;

namespace KareAlanCevreClass
{
    public partial class frmKup : Form
    {
        public frmKup()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Kontrol kontrol = new Kontrol();

            string ayritMetin = txtAyrit.Text;

            if (kontrol.Bosluk(ayritMetin))
            {
                MessageBox.Show("Ayrıt uzunluğu boş bırakılamaz!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtAyrit.Focus();
                return;
            }


            if (!kontrol.RakamKontrol(ayritMetin))
            {
                MessageBox.Show("Ayrıt uzunluğu için lütfen sadece rakam giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAyrit.Focus();
                return;
            }

            if (!kontrol.PozitifSayi(ayritMetin))
            {
                MessageBox.Show("Ayrıt uzunluğu 0'dan büyük olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAyrit.Focus();
                return;
            }

            double ayrit = Convert.ToDouble(ayritMetin);
            Kup kup = new Kup(ayrit);

            MessageBox.Show("Hacim : " + kup.HacimHesapla());
            MessageBox.Show("Yüzey Alanı : " + kup.YuzeyAlaniHesapla());
            MessageBox.Show("Ayrıt Toplamı : " + kup.AyritToplamiHesapla());
            MessageBox.Show("Yüzey Köşegeni : " + kup.YuzeyKosegeniHesapla());
            MessageBox.Show("Cisim Köşegeni : " + kup.CisimKosegeniHesapla());
        }

        private void frmKup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Anaform anaform = new Anaform();
            anaform.Show();
        }
    }
}
