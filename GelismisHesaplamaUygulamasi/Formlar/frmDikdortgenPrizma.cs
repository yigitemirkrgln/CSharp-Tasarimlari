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
    public partial class frmDikdortgenPrizma : Form
    {
        public frmDikdortgenPrizma()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Kontrol kontrol = new Kontrol();

            string uzunlukMetin = txtUzunluk.Text;
            string genislikMetin = txtGenislik.Text;
            string yukseklikMetin = txtYukseklik.Text;

            if (kontrol.Bosluk(uzunlukMetin))
            {
                MessageBox.Show("Uzunluk alanı boş bırakılamaz!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtUzunluk.Focus();
                return;
            }

            if (!kontrol.RakamKontrol(uzunlukMetin))
            {
                MessageBox.Show("Uzunluk alanına sadece rakam giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUzunluk.Focus();
                return;
            }

            if (!kontrol.PozitifSayi(uzunlukMetin))
            {
                MessageBox.Show("Uzunluk alanı sıfırdan büyük olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUzunluk.Focus();
                return;
            }

            if (kontrol.Bosluk(genislikMetin))
            {
                MessageBox.Show("Genişlik alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUzunluk.Focus();
                return;
            }

            if (!kontrol.RakamKontrol(genislikMetin))
            {
                MessageBox.Show("Genişlik alanına sadece rakam giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUzunluk.Focus();
                return;
            }

            if (!kontrol.PozitifSayi(genislikMetin))
            {
                MessageBox.Show("Genişlik alanı sıfırdan büyük olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUzunluk.Focus();
                return;
            }

            if (kontrol.Bosluk(yukseklikMetin))
            {
                MessageBox.Show("Yükseklik alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUzunluk.Focus();
                return;
            }

            if (!kontrol.RakamKontrol(yukseklikMetin))
            {
                MessageBox.Show("Yükseklik alanına sadece rakam giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUzunluk.Focus();
                return;
            }

            if (!kontrol.PozitifSayi(yukseklikMetin))
            {
                MessageBox.Show("Yükseklik alanı sıfırdan büyük olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUzunluk.Focus();
                return;
            }

            double uzunluk = Convert.ToDouble(uzunlukMetin);
            double genislik = Convert.ToDouble(genislikMetin);
            double yukseklik = Convert.ToDouble(yukseklikMetin);

            DikdortgenPrizma dikdortgenprizma = new DikdortgenPrizma(uzunluk, genislik, yukseklik);

            MessageBox.Show("Hacim : " + dikdortgenprizma.HacimHesapla());
            MessageBox.Show("Yüzey Alanı : " + dikdortgenprizma.YuzeyAlaniHesapla());
            MessageBox.Show("Ayrıt Toplamları : " + dikdortgenprizma.AyritToplamlariHesapla());
        }

        private void frmDikdortgenPrizma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Anaform anaform = new Anaform();
            anaform.Show();
        }
    }
}
