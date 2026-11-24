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
    public partial class frmUcgenPrizma : Form
    {
        public frmUcgenPrizma()
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
            string prizmaYuksekligiMetin = txtPrizmaYukseklik.Text;

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
                MessageBox.Show("Taban kenarı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaban.Focus();
                return;
            }
            if (!kontrol.RakamKontrol(tabanMetin))
            {
                MessageBox.Show("Taban kenarı için lütfen sadece rakam giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaban.Focus();
                return;
            }
            if (!kontrol.PozitifSayi(tabanMetin))
            {
                MessageBox.Show("Taban kenarı 0'dan büyük olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaban.Focus();
                return;
            }

            if (kontrol.Bosluk(yukseklikMetin))
            {
                MessageBox.Show("Taban yüksekliği boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYukseklik.Focus();
                return;
            }
            if (!kontrol.RakamKontrol(yukseklikMetin))
            {
                MessageBox.Show("Taban yüksekliği için lütfen sadece rakam giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYukseklik.Focus();
                return;
            }
            if (!kontrol.PozitifSayi(yukseklikMetin))
            {
                MessageBox.Show("Taban yüksekliği 0'dan büyük olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYukseklik.Focus();
                return;
            }

            if (kontrol.Bosluk(prizmaYuksekligiMetin))
            {
                MessageBox.Show("Prizma yüksekliği boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrizmaYukseklik.Focus();
                return;
            }
            if (!kontrol.RakamKontrol(prizmaYuksekligiMetin))
            {
                MessageBox.Show("Prizma yüksekliği için lütfen sadece rakam giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrizmaYukseklik.Focus();
                return;
            }
            if (!kontrol.PozitifSayi(prizmaYuksekligiMetin))
            {
                MessageBox.Show("Prizma yüksekliği 0'dan büyük olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrizmaYukseklik.Focus();
                return;

            }

            double k1 = Convert.ToDouble(k1Metin);
            double k2 = Convert.ToDouble(k2Metin);
            double k3 = Convert.ToDouble(k3Metin);
            double taban = Convert.ToDouble(tabanMetin);
            double yukseklik = Convert.ToDouble(yukseklikMetin);
            double prizmaYuksekligi = Convert.ToDouble(prizmaYuksekligiMetin);

            if (!kontrol.UcgenKenarKontrol(k1, k2, k3))
            {
                MessageBox.Show("Girilen kenar uzunlukları ile geçerli bir üçgen taban oluşturulamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKenar1.Focus();
                return;
            }

            UcgenPrizma prizma = new UcgenPrizma(k1, k2, k3, taban, yukseklik, prizmaYuksekligi);

            MessageBox.Show("Taban Alanı : " + prizma.TabanAlaniHesapla());
            MessageBox.Show("Yanal Alan : " + prizma.YanalAlanHesapla());
            MessageBox.Show("Yüzey Alanı : " + prizma.YuzeyAlaniHesapla());
            MessageBox.Show("Hacim : " + prizma.HacimHesapla());

        }

        private void frmUcgenPrizma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Anaform anaform = new Anaform();
            anaform.Show();
        }
    }
}
