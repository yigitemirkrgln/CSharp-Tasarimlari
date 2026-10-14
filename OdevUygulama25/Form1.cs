namespace OdevUygulama25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            byte Ortalama;
            Ortalama = Convert.ToByte(txtNotOrtalamasi.Text);

            if (Ortalama >= 50)
            {
                if (Ortalama >= 85)
                {
                    lblSonuc.Text = "Takdir Belgesi Almaya Hak Kazandýnýz.";
                }
                else if (Ortalama >=70)
                {
                    lblSonuc.Text = "Teþekkür Belgesi Almaya Hak Kazandýnýz.";
                }
                else
                {
                    lblSonuc.Text = "Belge Almadan Sýnýfý Geçtiniz";
                }
            }
            else
            {
                lblSonuc.Text = "Sýnýfý Geçmek Ýçin Yeterli Not Alamadýnýz";
            }
        }
    }
}
