namespace OdevUygulama21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = "yigit1234";
            KullaniciAdi = txtKullaniciAdi.Text;
            if (KullaniciAdi == "yigit1234")
            {
                MessageBox.Show("Kullanýcý Sisteme Kayýtlýdýr.");
            }
            else
            {
                MessageBox.Show("Kullanýcý Sisteme Kayýtlý Deðildir");
            }
        }
    }
}
