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
    public partial class frmDikdortgen : Form
    {
        public frmDikdortgen()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Kontrol kontrol = new Kontrol();

            string uzunKenarSt = txtUzunKenar.Text;
            string kisaKenarSt = txtKisaKenar.Text;

            if (kontrol.Bosluk(kisaKenarSt))
            {
                MessageBox.Show("Kısa kenar boş bırakılamaz!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtKisaKenar.Focus();
                return;
            }

            if (!kontrol.RakamKontrol(kisaKenarSt))
            {
                MessageBox.Show("Kısa kenara sadece rakam giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKisaKenar.Focus();
                return;
            }

            if (!kontrol.PozitifSayi(kisaKenarSt))
            {
                MessageBox.Show("Kısa kenar negatif veya sıfır olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKisaKenar.Focus();
                return;
            }

            if (kontrol.Bosluk(uzunKenarSt))
            {
                MessageBox.Show("Uzun kenar boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUzunKenar.Focus();
                return;
            }

            if (!kontrol.RakamKontrol(uzunKenarSt))
            {
                MessageBox.Show("Uzun kenara sadece rakam giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUzunKenar.Focus();
                return;
            }

            if (!kontrol.PozitifSayi(uzunKenarSt))
            {
                MessageBox.Show("Uzun kenar negatif veya sıfır olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUzunKenar.Focus();
                return;
            }

            double kisaKenar = Convert.ToDouble(kisaKenarSt);

            double uzunKenar = Convert.ToDouble(uzunKenarSt);

            if (!kontrol.KenarKontrol(kisaKenar, uzunKenar))
            {
                MessageBox.Show("Kısa kenar uzun kenardan küçük olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKisaKenar.Focus();
                return;
            }

            Dikdortgen dikdortgen = new Dikdortgen(kisaKenar, uzunKenar);
                
            MessageBox.Show("Alan : " + dikdortgen.AlanHesapla());  
            MessageBox.Show("Çevre : " + dikdortgen.CevreHesapla());

        }

        private void frmDikdortgen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Anaform anaform = new Anaform();
            anaform.Show();
        }
    }
}
