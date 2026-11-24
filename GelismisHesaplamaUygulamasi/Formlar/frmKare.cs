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
    public partial class frmKare : Form
    {
        public frmKare()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Kontrol kontrol = new Kontrol();

            string kenarMetin = txtKenar.Text;

            if (kontrol.Bosluk(kenarMetin))
            {
                MessageBox.Show("Kenar uzunluğu boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKenar.Focus();
                return;
            }

            if (!kontrol.RakamKontrol(kenarMetin))
            {
                MessageBox.Show("Kenar uzunluğu için lütfen sadece rakam giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKenar.Focus();
                return;
            }

            if (!kontrol.PozitifSayi(kenarMetin))
            {
                MessageBox.Show("Kenar uzunluğu 0'dan büyük olmalıdır!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtKenar.Focus();
                return;
            }

            double kenar = Convert.ToDouble(kenarMetin);
            Kare kare = new Kare(kenar);

            MessageBox.Show("Çevre : " + kare.CevreHesapla());
            MessageBox.Show("Alan : " + kare.AlanHesapla());
            MessageBox.Show("Köşegenleri : " + kare.KosegenHesapla());
        }

        private void frmKare_FormClosed(object sender, FormClosedEventArgs e)
        {
            Anaform anaform = new Anaform();
            anaform.Show();
        }
    }
}
