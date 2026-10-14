namespace HesapMakinesiDortIslem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char karakter;
        int ilk_deger, ikinciDeger;
        private void btnBir_Click(object sender, EventArgs e)
        {
            txtBuyukSonuc.Text += "1";
            txtKucukSonuc.Text += "1";
        }

        private void btnIki_Click(object sender, EventArgs e)
        {
            txtBuyukSonuc.Text += "2";
            txtKucukSonuc.Text += "2";
        }

        private void btnUc_Click(object sender, EventArgs e)
        {
            txtBuyukSonuc.Text += "3";
            txtKucukSonuc.Text += "3";
        }

        private void btnDort_Click(object sender, EventArgs e)
        {
            txtBuyukSonuc.Text += "4";
            txtKucukSonuc.Text += "4";
        }

        private void btnBes_Click(object sender, EventArgs e)
        {
            txtBuyukSonuc.Text += "5";
            txtKucukSonuc.Text += "5";
        }

        private void btnAlti_Click(object sender, EventArgs e)
        {
            txtBuyukSonuc.Text += "6";
            txtKucukSonuc.Text += "6";
        }

        private void btnYedi_Click(object sender, EventArgs e)
        {
            txtBuyukSonuc.Text += "7";
            txtKucukSonuc.Text += "7";
        }

        private void btnSekiz_Click(object sender, EventArgs e)
        {
            txtBuyukSonuc.Text += "8";
            txtKucukSonuc.Text += "8";
        }

        private void btnDokuz_Click(object sender, EventArgs e)
        {
            txtBuyukSonuc.Text += "9";
            txtKucukSonuc.Text += "9";
        }

        private void btnSifir_Click(object sender, EventArgs e)
        {
            txtBuyukSonuc.Text += "0";
            txtKucukSonuc.Text += "0";
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            if (txtBuyukSonuc.Text != "")
            {
                karakter = '+';
                ilk_deger = Convert.ToInt32(txtBuyukSonuc.Text);
                txtBuyukSonuc.Text = "";
                txtKucukSonuc.Text += "+";
            }
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            if (txtBuyukSonuc.Text != "")
            {
                karakter = '-';
                ilk_deger = Convert.ToInt32(txtBuyukSonuc.Text);
                txtBuyukSonuc.Text = "";
                txtKucukSonuc.Text += "-";
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            if (txtBuyukSonuc.Text != "")
            {
                karakter = '*';
                ilk_deger = Convert.ToInt32(txtBuyukSonuc.Text);
                txtBuyukSonuc.Text = "";
                txtKucukSonuc.Text += "*";
            }
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            if (Kontrol(txtBuyukSonuc.Text))
            {
                karakter = '/';
                ilk_deger = Convert.ToInt32(txtBuyukSonuc.Text);
                txtBuyukSonuc.Text = "";
                txtKucukSonuc.Text += "/";
            }
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            if (txtBuyukSonuc.Text != "")
            {
                ikinciDeger = Convert.ToInt32(txtBuyukSonuc.Text);
                if (karakter == '+')
                {
                    int toplamSonuc = ilk_deger + ikinciDeger;
                    txtBuyukSonuc.Text = "";
                    txtBuyukSonuc.Text = toplamSonuc.ToString();
                }
                else if (karakter == '-')
                {
                    int toplamSonuc = ilk_deger - ikinciDeger;
                    txtBuyukSonuc.Text = "";
                    txtBuyukSonuc.Text = toplamSonuc.ToString();
                }
                else if (karakter == '*')
                {
                    int toplamSonuc = ilk_deger * ikinciDeger;
                    txtBuyukSonuc.Text = "";
                    txtBuyukSonuc.Text = toplamSonuc.ToString();
                }
                else if (karakter == '/')
                {
                    if (ikinciDeger == 0)
                    {
                        MessageBox.Show("Bir Sayý Sýfýra Bölünemez", "ÝÞLEM HATASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBuyukSonuc.Clear();
                    }
                    else
                    {
                        int toplamSonuc = ilk_deger / ikinciDeger;
                        txtBuyukSonuc.Text = "";
                        txtBuyukSonuc.Text = toplamSonuc.ToString();
                    }
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKucukSonuc.Clear();
            txtBuyukSonuc.Clear();
            karakter = ' ';
            ilk_deger = 0;
            ikinciDeger = 0;
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            if (txtBuyukSonuc.Text != "")
            {
                string degerBuyuk = txtBuyukSonuc.Text;
                int karakterBoyutuBuyuk = degerBuyuk.Length - 1;
                degerBuyuk = degerBuyuk.Remove(karakterBoyutuBuyuk);
                txtBuyukSonuc.Text = degerBuyuk.ToString();

                string degerKucuk = txtKucukSonuc.Text;
                int karakterBoyutuKucuk = degerKucuk.Length - 1;
                degerKucuk = degerKucuk.Remove(karakterBoyutuKucuk);
                txtKucukSonuc.Text = degerKucuk.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        bool Kontrol (string knt)
        {
            if (knt != "")
              return  true;
            else return false;
        }
    }
}
