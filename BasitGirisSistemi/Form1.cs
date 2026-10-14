namespace BasitGirisSistemi
{
    public partial class Form1 : Form
    {
        string KullaniciAdi = "Yigit1923";
        string Sifre = "Fenerbahce1907";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (KullaniciAdi == txtKullaniciAdi.Text && Sifre == txtSifre.Text)
            {
                MessageBox.Show("Hesaba Giriþ Yapýldý.", "Hoþgeldiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AnaForm anaForm = new AnaForm();
                anaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý Adý veya Þifre Yanlýþ.", "Giriþ Yapýlamadý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Þifreniz = Fenerbahce1907", "Þifre Hatýrlatýcýsý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            string yasakliKarakterler = "@!.,?#$%* ";

            if (yasakliKarakterler.Contains(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(" Kullanamayacaðýnýz Yasaklý Karakterler = @!.,?#$%* ", "Karakter Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            string yasakliKarakterler = "@!.,?#$%* ";

            if (yasakliKarakterler.Contains(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(" Kullanamayacaðýnýz Yasaklý Karakterler = @!.,?#$%* ", "Karakter Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifreyiGoster.Checked == true)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
