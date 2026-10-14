namespace OdevUygulama26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGunOgren_Click(object sender, EventArgs e)
        {
            int gun = Convert.ToInt32(DateTime.Now.DayOfWeek);
            switch (gun)
            {
                case 1:
                    MessageBox.Show("Pazartesi");
                    break;
                case 2:
                    MessageBox.Show("Salý");
                    break;
                case 3:
                    MessageBox.Show("Çarþamba");
                    break;
                case 4:
                    MessageBox.Show("Perþembe");
                    break;
                case 5:
                    MessageBox.Show("Cuma");
                        break;
                case 6:
                    MessageBox.Show("Cumartesi");
                    break;
                case 0:
                    MessageBox.Show("Pazar");
                    break;
                default:
                    MessageBox.Show("Bir Hata Oluþtu", "Uyarý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
