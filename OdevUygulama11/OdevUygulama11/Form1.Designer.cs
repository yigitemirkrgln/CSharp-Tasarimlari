namespace OdevUygulama11
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
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblTrueFalse = new System.Windows.Forms.Label();
            this.cbLambaAcKapat = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(2, 145);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(193, 24);
            this.lblAciklama.TabIndex = 0;
            this.lblAciklama.Text = "Lambanın Durumu :";
            // 
            // lblTrueFalse
            // 
            this.lblTrueFalse.AutoSize = true;
            this.lblTrueFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTrueFalse.Location = new System.Drawing.Point(201, 148);
            this.lblTrueFalse.Name = "lblTrueFalse";
            this.lblTrueFalse.Size = new System.Drawing.Size(94, 20);
            this.lblTrueFalse.TabIndex = 0;
            this.lblTrueFalse.Text = "Bekleniyor...";
            // 
            // cbLambaAcKapat
            // 
            this.cbLambaAcKapat.AutoSize = true;
            this.cbLambaAcKapat.Location = new System.Drawing.Point(16, 56);
            this.cbLambaAcKapat.Name = "cbLambaAcKapat";
            this.cbLambaAcKapat.Size = new System.Drawing.Size(114, 17);
            this.cbLambaAcKapat.TabIndex = 1;
            this.cbLambaAcKapat.Text = "Lambayı Aç/Kapat";
            this.cbLambaAcKapat.UseVisualStyleBackColor = true;
            this.cbLambaAcKapat.CheckedChanged += new System.EventHandler(this.cbLambaAcKapat_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(296, 208);
            this.Controls.Add(this.cbLambaAcKapat);
            this.Controls.Add(this.lblTrueFalse);
            this.Controls.Add(this.lblAciklama);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "True/False";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblTrueFalse;
        private System.Windows.Forms.CheckBox cbLambaAcKapat;
    }
}

