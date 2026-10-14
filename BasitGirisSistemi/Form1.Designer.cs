namespace BasitGirisSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGirisYap = new Button();
            cbBeniHatirla = new CheckBox();
            label1 = new Label();
            txtKullaniciAdi = new TextBox();
            label2 = new Label();
            txtSifre = new TextBox();
            label3 = new Label();
            btnSifremiUnuttum = new Button();
            pictureBox1 = new PictureBox();
            cbSifreyiGoster = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.FromArgb(15, 157, 88);
            btnGirisYap.FlatAppearance.BorderSize = 0;
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.Font = new Font("Segoe UI", 12F);
            btnGirisYap.ForeColor = Color.White;
            btnGirisYap.Location = new Point(36, 416);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(327, 31);
            btnGirisYap.TabIndex = 0;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // cbBeniHatirla
            // 
            cbBeniHatirla.AutoSize = true;
            cbBeniHatirla.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbBeniHatirla.ForeColor = SystemColors.GrayText;
            cbBeniHatirla.Location = new Point(203, 328);
            cbBeniHatirla.Name = "cbBeniHatirla";
            cbBeniHatirla.Size = new Size(119, 25);
            cbBeniHatirla.TabIndex = 1;
            cbBeniHatirla.Text = "Beni Hatırla";
            cbBeniHatirla.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(98, 152);
            label1.Name = "label1";
            label1.Size = new Size(194, 30);
            label1.TabIndex = 2;
            label1.Text = "Hesabına Giriş Yap";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI", 13F);
            txtKullaniciAdi.Location = new Point(36, 231);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(327, 31);
            txtKullaniciAdi.TabIndex = 3;
            txtKullaniciAdi.KeyPress += txtKullaniciAdi_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(36, 203);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 4;
            label2.Text = "Kullanıcı Adı";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 13F);
            txtSifre.Location = new Point(36, 289);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(327, 31);
            txtSifre.TabIndex = 3;
            txtSifre.TextChanged += txtSifre_TextChanged;
            txtSifre.KeyPress += txtSifre_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(36, 265);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 4;
            label3.Text = "Şifre";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSifremiUnuttum
            // 
            btnSifremiUnuttum.BackColor = Color.White;
            btnSifremiUnuttum.FlatAppearance.BorderSize = 0;
            btnSifremiUnuttum.FlatStyle = FlatStyle.Flat;
            btnSifremiUnuttum.Font = new Font("Segoe UI", 12F);
            btnSifremiUnuttum.ForeColor = Color.FromArgb(15, 157, 88);
            btnSifremiUnuttum.Location = new Point(90, 359);
            btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            btnSifremiUnuttum.Size = new Size(202, 31);
            btnSifremiUnuttum.TabIndex = 0;
            btnSifremiUnuttum.Text = "Şifremi Unuttum";
            btnSifremiUnuttum.UseVisualStyleBackColor = false;
            btnSifremiUnuttum.Click += btnSifremiUnuttum_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(147, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // cbSifreyiGoster
            // 
            cbSifreyiGoster.AutoSize = true;
            cbSifreyiGoster.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cbSifreyiGoster.ForeColor = SystemColors.GrayText;
            cbSifreyiGoster.Location = new Point(36, 326);
            cbSifreyiGoster.Name = "cbSifreyiGoster";
            cbSifreyiGoster.Size = new Size(122, 24);
            cbSifreyiGoster.TabIndex = 6;
            cbSifreyiGoster.Text = "Şifremi Göster";
            cbSifreyiGoster.UseVisualStyleBackColor = true;
            cbSifreyiGoster.CheckedChanged += cbSifreyiGoster_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(390, 468);
            Controls.Add(cbSifreyiGoster);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label1);
            Controls.Add(cbBeniHatirla);
            Controls.Add(btnSifremiUnuttum);
            Controls.Add(btnGirisYap);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Yap";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGirisYap;
        private CheckBox cbBeniHatirla;
        private Label label1;
        private TextBox txtKullaniciAdi;
        private Label label2;
        private TextBox txtSifre;
        private Label label3;
        private Button btnSifremiUnuttum;
        private PictureBox pictureBox1;
        private CheckBox cbSifreyiGoster;
    }
}
