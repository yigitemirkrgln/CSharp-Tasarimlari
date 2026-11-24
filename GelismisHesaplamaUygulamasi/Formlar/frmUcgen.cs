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
    public partial class frmUcgen : Form
    {
        public frmUcgen()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Kontrol kontrol = new Kontrol();

            string k1Metin = txtKenar1.Text;
            string k2Metin = txtKenar2.Text;
            string k3Metin = txtKenar3.Text;
            string tabanMetin = txtTaban.Text;
            string yukseklikMetin = txtYukseklik.Text;

            if (kontrol.Bosluk(k1Metin))
            {
                MessageBox.Show("1. Kenar alanı boş bırakılamaz!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtKenar1.Focus();
                return;
            }
            if (!kontrol.RakamKontrol(k1Metin))
            {
                MessageBox.Show("1. Kenar için lütfen sadece rakam giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKenar1.Focus();
                return;
            }
            if (!kontrol.PozitifSayi(k1Metin))
            {
                MessageBox.Show("1. Kenar 0'dan büyük olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKenar1.Focus();
                return;
            }

            if (kontrol.Bosluk(k2Metin))
            {
                MessageBox.Show("2. Kenar alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKenar2.Focus();
                return;
            }
            if (!kontrol.RakamKontrol(k2Metin))
            {
                MessageBox.Show("2. Kenar için lütfen sadece rakam giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKenar2.Focus();
                return;
            }
            if (!kontrol.PozitifSayi(k2Metin))
            {
                MessageBox.Show("2. Kenar 0'dan büyük olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKenar2.Focus();
                return;
            }

            if (kontrol.Bosluk(k3Metin))
            {
                MessageBox.Show("3. Kenar alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKenar3.Focus();
                return;
            }
            if (!kontrol.RakamKontrol(k3Metin))
            {
                MessageBox.Show("3. Kenar için lütfen sadece rakam giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKenar3.Focus();
                return;
            }
            if (!kontrol.PozitifSayi(k3Metin))
            {
                MessageBox.Show("3. Kenar 0'dan büyük olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKenar3.Focus();
                return;
            }

            if (kontrol.Bosluk(tabanMetin))
            {
                MessageBox.Show("Taban alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaban.Focus();
                return;
            }
            if (!kontrol.RakamKontrol(tabanMetin))
            {
                MessageBox.Show("Taban için lütfen sadece rakam giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaban.Focus();
                return;
            }
            if (!kontrol.PozitifSayi(tabanMetin))
            {
                MessageBox.Show("Taban 0'dan büyük olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaban.Focus();
                return;
            }

            if (kontrol.Bosluk(yukseklikMetin))
            {
                MessageBox.Show("Yükseklik alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYukseklik.Focus();
                return;
            }
            if (!kontrol.RakamKontrol(yukseklikMetin))
            {
                MessageBox.Show("Yükseklik için lütfen sadece rakam giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYukseklik.Focus();
                return;
            }
            if (!kontrol.PozitifSayi(yukseklikMetin))
            {
                MessageBox.Show("Yükseklik 0'dan büyük olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYukseklik.Focus();
                return;
            }

            double kenar1 = Convert.ToDouble(k1Metin);
            double kenar2 = Convert.ToDouble(k2Metin);
            double kenar3 = Convert.ToDouble(k3Metin);
            double taban = Convert.ToDouble(tabanMetin);
            double yukseklik = Convert.ToDouble(yukseklikMetin);

            if (!kontrol.UcgenKenarKontrol(kenar1, kenar2, kenar3))
            {
                MessageBox.Show("Girilen kenar uzunlukları ile bir üçgen oluşturulamaz! (İki kenarın toplamı diğer kenardan büyük olmalıdır.)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKenar1.Focus();
                return;
            }

            Ucgen ucgen = new Ucgen(kenar1, kenar2, kenar3, taban, yukseklik);

            MessageBox.Show("Alan : " + ucgen.AlanHesapla(taban, yukseklik));
            MessageBox.Show("Çevre : " + ucgen.CevreHesapla());
        }

        private void frmUcgen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Anaform anaform = new Anaform();
            anaform.Show();
        }
    }
}
