namespace OdevSayfa35SiraSizde
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
            this.btnDegerGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDegerGoster
            // 
            this.btnDegerGoster.BackColor = System.Drawing.Color.Tomato;
            this.btnDegerGoster.Location = new System.Drawing.Point(65, 59);
            this.btnDegerGoster.Name = "btnDegerGoster";
            this.btnDegerGoster.Size = new System.Drawing.Size(75, 63);
            this.btnDegerGoster.TabIndex = 0;
            this.btnDegerGoster.Text = "Değeri Göster";
            this.btnDegerGoster.UseVisualStyleBackColor = false;
            this.btnDegerGoster.Click += new System.EventHandler(this.btnDegerGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(220, 183);
            this.Controls.Add(this.btnDegerGoster);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDegerGoster;
    }
}

