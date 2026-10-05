namespace OdevUygulama13
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIkıncıOrnekKod = new System.Windows.Forms.Button();
            this.btnBirinciOrnekKod = new System.Windows.Forms.Button();
            this.txtBir = new System.Windows.Forms.TextBox();
            this.txtIkı = new System.Windows.Forms.TextBox();
            this.txtUc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIkıncıOrnekKod
            // 
            this.btnIkıncıOrnekKod.Location = new System.Drawing.Point(181, 28);
            this.btnIkıncıOrnekKod.Name = "btnIkıncıOrnekKod";
            this.btnIkıncıOrnekKod.Size = new System.Drawing.Size(104, 40);
            this.btnIkıncıOrnekKod.TabIndex = 0;
            this.btnIkıncıOrnekKod.Text = "İkinci Örnek Kod";
            this.btnIkıncıOrnekKod.UseVisualStyleBackColor = true;
            this.btnIkıncıOrnekKod.Click += new System.EventHandler(this.btnIkıncıOrnekKod_Click);
            // 
            // btnBirinciOrnekKod
            // 
            this.btnBirinciOrnekKod.Location = new System.Drawing.Point(24, 28);
            this.btnBirinciOrnekKod.Name = "btnBirinciOrnekKod";
            this.btnBirinciOrnekKod.Size = new System.Drawing.Size(104, 40);
            this.btnBirinciOrnekKod.TabIndex = 1;
            this.btnBirinciOrnekKod.Text = "Birinci Örnek Kod";
            this.btnBirinciOrnekKod.UseVisualStyleBackColor = true;
            this.btnBirinciOrnekKod.Click += new System.EventHandler(this.btnBirinciOrnekKod_Click);
            // 
            // txtBir
            // 
            this.txtBir.Location = new System.Drawing.Point(181, 77);
            this.txtBir.Name = "txtBir";
            this.txtBir.Size = new System.Drawing.Size(104, 20);
            this.txtBir.TabIndex = 2;
            // 
            // txtIkı
            // 
            this.txtIkı.Location = new System.Drawing.Point(181, 103);
            this.txtIkı.Name = "txtIkı";
            this.txtIkı.Size = new System.Drawing.Size(104, 20);
            this.txtIkı.TabIndex = 2;
            this.txtIkı.TextChanged += new System.EventHandler(this.txtIkı_TextChanged);
            // 
            // txtUc
            // 
            this.txtUc.Location = new System.Drawing.Point(181, 129);
            this.txtUc.Name = "txtUc";
            this.txtUc.Size = new System.Drawing.Size(104, 20);
            this.txtUc.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(438, 275);
            this.Controls.Add(this.txtUc);
            this.Controls.Add(this.txtIkı);
            this.Controls.Add(this.txtBir);
            this.Controls.Add(this.btnBirinciOrnekKod);
            this.Controls.Add(this.btnIkıncıOrnekKod);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIkıncıOrnekKod;
        private System.Windows.Forms.Button btnBirinciOrnekKod;
        private System.Windows.Forms.TextBox txtBir;
        private System.Windows.Forms.TextBox txtIkı;
        private System.Windows.Forms.TextBox txtUc;
    }
}

