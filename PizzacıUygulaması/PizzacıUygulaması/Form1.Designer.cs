namespace PizzacıUygulaması
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
            this.lblTatliAdet = new System.Windows.Forms.Label();
            this.lblTatli = new System.Windows.Forms.Label();
            this.lblIcecekAdet = new System.Windows.Forms.Label();
            this.lblIcecek = new System.Windows.Forms.Label();
            this.lblPizzaAdet = new System.Windows.Forms.Label();
            this.lblPizza = new System.Windows.Forms.Label();
            this.lblPizzaSonuc = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblIcecekSonuc = new System.Windows.Forms.Label();
            this.lblTatliSonuc = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.txtPizzaAdet = new System.Windows.Forms.TextBox();
            this.txtIcecekAdet = new System.Windows.Forms.TextBox();
            this.txtTatliAdet = new System.Windows.Forms.TextBox();
            this.txtPizzaToplam = new System.Windows.Forms.TextBox();
            this.txtIcecekToplam = new System.Windows.Forms.TextBox();
            this.txtTatliToplam = new System.Windows.Forms.TextBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTatliAdet
            // 
            this.lblTatliAdet.AutoSize = true;
            this.lblTatliAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTatliAdet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTatliAdet.Location = new System.Drawing.Point(229, 118);
            this.lblTatliAdet.Name = "lblTatliAdet";
            this.lblTatliAdet.Size = new System.Drawing.Size(95, 20);
            this.lblTatliAdet.TabIndex = 0;
            this.lblTatliAdet.Text = "Tatlı Adedi : ";
            // 
            // lblTatli
            // 
            this.lblTatli.AutoSize = true;
            this.lblTatli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTatli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTatli.Location = new System.Drawing.Point(12, 118);
            this.lblTatli.Name = "lblTatli";
            this.lblTatli.Size = new System.Drawing.Size(131, 20);
            this.lblTatli.TabIndex = 0;
            this.lblTatli.Text = "Tatlı Fiyatı : 60 TL";
            // 
            // lblIcecekAdet
            // 
            this.lblIcecekAdet.AutoSize = true;
            this.lblIcecekAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIcecekAdet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIcecekAdet.Location = new System.Drawing.Point(229, 78);
            this.lblIcecekAdet.Name = "lblIcecekAdet";
            this.lblIcecekAdet.Size = new System.Drawing.Size(113, 20);
            this.lblIcecekAdet.TabIndex = 0;
            this.lblIcecekAdet.Text = "İçecek Adedi : ";
            // 
            // lblIcecek
            // 
            this.lblIcecek.AutoSize = true;
            this.lblIcecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIcecek.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIcecek.Location = new System.Drawing.Point(12, 78);
            this.lblIcecek.Name = "lblIcecek";
            this.lblIcecek.Size = new System.Drawing.Size(149, 20);
            this.lblIcecek.TabIndex = 0;
            this.lblIcecek.Text = "İçecek Fiyatı : 40 TL";
            // 
            // lblPizzaAdet
            // 
            this.lblPizzaAdet.AutoSize = true;
            this.lblPizzaAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPizzaAdet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPizzaAdet.Location = new System.Drawing.Point(229, 33);
            this.lblPizzaAdet.Name = "lblPizzaAdet";
            this.lblPizzaAdet.Size = new System.Drawing.Size(104, 20);
            this.lblPizzaAdet.TabIndex = 0;
            this.lblPizzaAdet.Text = "Pizza Adedi : ";
            // 
            // lblPizza
            // 
            this.lblPizza.AutoSize = true;
            this.lblPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPizza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPizza.Location = new System.Drawing.Point(12, 33);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(149, 20);
            this.lblPizza.TabIndex = 0;
            this.lblPizza.Text = "Pizza Fiyatı : 150 TL";
            // 
            // lblPizzaSonuc
            // 
            this.lblPizzaSonuc.AutoSize = true;
            this.lblPizzaSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPizzaSonuc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPizzaSonuc.Location = new System.Drawing.Point(12, 236);
            this.lblPizzaSonuc.Name = "lblPizzaSonuc";
            this.lblPizzaSonuc.Size = new System.Drawing.Size(118, 20);
            this.lblPizzaSonuc.TabIndex = 0;
            this.lblPizzaSonuc.Text = "Pizza Toplamı : ";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(131, 171);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 1;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblIcecekSonuc
            // 
            this.lblIcecekSonuc.AutoSize = true;
            this.lblIcecekSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIcecekSonuc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIcecekSonuc.Location = new System.Drawing.Point(12, 280);
            this.lblIcecekSonuc.Name = "lblIcecekSonuc";
            this.lblIcecekSonuc.Size = new System.Drawing.Size(123, 20);
            this.lblIcecekSonuc.TabIndex = 0;
            this.lblIcecekSonuc.Text = "İçecek Toplamı :";
            // 
            // lblTatliSonuc
            // 
            this.lblTatliSonuc.AutoSize = true;
            this.lblTatliSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTatliSonuc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTatliSonuc.Location = new System.Drawing.Point(12, 325);
            this.lblTatliSonuc.Name = "lblTatliSonuc";
            this.lblTatliSonuc.Size = new System.Drawing.Size(109, 20);
            this.lblTatliSonuc.TabIndex = 0;
            this.lblTatliSonuc.Text = "Tatlı Toplamı : ";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTutar.Location = new System.Drawing.Point(12, 368);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(114, 20);
            this.lblTutar.TabIndex = 0;
            this.lblTutar.Text = "Toplam Tutar : ";
            // 
            // txtPizzaAdet
            // 
            this.txtPizzaAdet.Location = new System.Drawing.Point(371, 35);
            this.txtPizzaAdet.Name = "txtPizzaAdet";
            this.txtPizzaAdet.Size = new System.Drawing.Size(24, 20);
            this.txtPizzaAdet.TabIndex = 2;
            // 
            // txtIcecekAdet
            // 
            this.txtIcecekAdet.Location = new System.Drawing.Point(371, 78);
            this.txtIcecekAdet.Name = "txtIcecekAdet";
            this.txtIcecekAdet.Size = new System.Drawing.Size(24, 20);
            this.txtIcecekAdet.TabIndex = 2;
            // 
            // txtTatliAdet
            // 
            this.txtTatliAdet.Location = new System.Drawing.Point(371, 118);
            this.txtTatliAdet.Name = "txtTatliAdet";
            this.txtTatliAdet.Size = new System.Drawing.Size(24, 20);
            this.txtTatliAdet.TabIndex = 2;
            // 
            // txtPizzaToplam
            // 
            this.txtPizzaToplam.Location = new System.Drawing.Point(148, 236);
            this.txtPizzaToplam.Name = "txtPizzaToplam";
            this.txtPizzaToplam.Size = new System.Drawing.Size(100, 20);
            this.txtPizzaToplam.TabIndex = 3;
            // 
            // txtIcecekToplam
            // 
            this.txtIcecekToplam.Location = new System.Drawing.Point(148, 280);
            this.txtIcecekToplam.Name = "txtIcecekToplam";
            this.txtIcecekToplam.Size = new System.Drawing.Size(100, 20);
            this.txtIcecekToplam.TabIndex = 3;
            // 
            // txtTatliToplam
            // 
            this.txtTatliToplam.Location = new System.Drawing.Point(148, 325);
            this.txtTatliToplam.Name = "txtTatliToplam";
            this.txtTatliToplam.Size = new System.Drawing.Size(100, 20);
            this.txtTatliToplam.TabIndex = 3;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(148, 370);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(100, 20);
            this.txtToplamTutar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(685, 677);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtTatliToplam);
            this.Controls.Add(this.txtIcecekToplam);
            this.Controls.Add(this.txtPizzaToplam);
            this.Controls.Add(this.txtTatliAdet);
            this.Controls.Add(this.txtIcecekAdet);
            this.Controls.Add(this.txtPizzaAdet);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblPizza);
            this.Controls.Add(this.lblIcecekAdet);
            this.Controls.Add(this.lblPizzaAdet);
            this.Controls.Add(this.lblTatli);
            this.Controls.Add(this.lblIcecek);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblTatliSonuc);
            this.Controls.Add(this.lblIcecekSonuc);
            this.Controls.Add(this.lblPizzaSonuc);
            this.Controls.Add(this.lblTatliAdet);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTatliAdet;
        private System.Windows.Forms.Label lblTatli;
        private System.Windows.Forms.Label lblIcecekAdet;
        private System.Windows.Forms.Label lblIcecek;
        private System.Windows.Forms.Label lblPizzaAdet;
        private System.Windows.Forms.Label lblPizza;
        private System.Windows.Forms.Label lblPizzaSonuc;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblIcecekSonuc;
        private System.Windows.Forms.Label lblTatliSonuc;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtPizzaAdet;
        private System.Windows.Forms.TextBox txtIcecekAdet;
        private System.Windows.Forms.TextBox txtTatliAdet;
        private System.Windows.Forms.TextBox txtPizzaToplam;
        private System.Windows.Forms.TextBox txtIcecekToplam;
        private System.Windows.Forms.TextBox txtTatliToplam;
        private System.Windows.Forms.TextBox txtToplamTutar;
    }
}

