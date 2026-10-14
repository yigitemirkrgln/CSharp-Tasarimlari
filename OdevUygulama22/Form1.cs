namespace OdevUygulama22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbLamba_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            if (cbLamba.Checked == true)
            {
                lbSistemRaporu.Items.Add("Lambalar Açýk");
            }
            else
            {
                lbSistemRaporu.Items.Add("Lambalar Kapalý");
            }
            if (cbKombi.Checked == true)
            {
                lbSistemRaporu.Items.Add("Kombi Açýk");
            }
            else
            {
                lbSistemRaporu.Items.Add("Kombi Kapalý");
            }
        }
    }
}
