namespace OdevUygulama21
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
            btnSorgula = new Button();
            txtKullaniciAdi = new TextBox();
            SuspendLayout();
            // 
            // btnSorgula
            // 
            btnSorgula.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSorgula.Location = new Point(115, 113);
            btnSorgula.Name = "btnSorgula";
            btnSorgula.Size = new Size(205, 40);
            btnSorgula.TabIndex = 0;
            btnSorgula.Text = "Sorgula";
            btnSorgula.UseVisualStyleBackColor = true;
            btnSorgula.Click += btnSorgula_Click;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtKullaniciAdi.Location = new Point(49, 51);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(338, 35);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(422, 269);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(btnSorgula);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Adı Sorgulama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSorgula;
        private TextBox txtKullaniciAdi;
    }
}
