using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KareAlanCevreClass.Sınıflar;

namespace KareAlanCevreClass
{
    public partial class frmDaire : Form
    {
        public frmDaire()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Kontrol kontrol = new Kontrol();
            

            string girilenDeger = txtYaricap.Text;

            if (kontrol.Bosluk(girilenDeger))
            {
                MessageBox.Show("Yarıçap boş bırakılamaz!","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYaricap.Focus();
                return;
            }

            if (!kontrol.RakamKontrol(girilenDeger))
            {
                MessageBox.Show("Sadece rakam giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYaricap.Focus();
                return;
            }

            if (!kontrol.PozitifSayi(girilenDeger))
            {
                MessageBox.Show("Sıfırdan büyük değer giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYaricap.Focus();
                return;
            }
            double yaricap = Convert.ToDouble(girilenDeger);
            Daire daire = new Daire(yaricap);

            MessageBox.Show("Alan : " + daire.AlanHesapla());
            MessageBox.Show("Çevre : " + daire.CevreHesapla());
        }

        private void frmDaire_FormClosed(object sender, FormClosedEventArgs e)
        {
            Anaform anaform = new Anaform();
            anaform.Show();
        }
    }
}
