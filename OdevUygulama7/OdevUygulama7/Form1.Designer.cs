namespace OdevUygulama7
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEkleme = new System.Windows.Forms.Button();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnEkleme
            // 
            this.btnEkleme.Location = new System.Drawing.Point(377, 117);
            this.btnEkleme.Name = "btnEkleme";
            this.btnEkleme.Size = new System.Drawing.Size(257, 28);
            this.btnEkleme.TabIndex = 1;
            this.btnEkleme.Text = "Sepete ekle";
            this.btnEkleme.UseVisualStyleBackColor = true;
            this.btnEkleme.Click += new System.EventHandler(this.btnEkleme_Click);
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(951, 23);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(300, 433);
            this.lstSepet.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1406, 491);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.btnEkleme);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEkleme;
        private System.Windows.Forms.ListBox lstSepet;
    }
}

