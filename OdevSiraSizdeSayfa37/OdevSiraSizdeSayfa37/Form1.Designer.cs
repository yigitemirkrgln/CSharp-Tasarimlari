namespace OdevSiraSizdeSayfa37
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.btnKaresiniAl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı Giriniz :";
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(127, 24);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(100, 20);
            this.txtGiris.TabIndex = 1;
            // 
            // btnKaresiniAl
            // 
            this.btnKaresiniAl.Location = new System.Drawing.Point(52, 75);
            this.btnKaresiniAl.Name = "btnKaresiniAl";
            this.btnKaresiniAl.Size = new System.Drawing.Size(100, 43);
            this.btnKaresiniAl.TabIndex = 2;
            this.btnKaresiniAl.Text = "Karesini Al";
            this.btnKaresiniAl.UseVisualStyleBackColor = true;
            this.btnKaresiniAl.Click += new System.EventHandler(this.btnKaresiniAl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(243, 151);
            this.Controls.Add(this.btnKaresiniAl);
            this.Controls.Add(this.txtGiris);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.Button btnKaresiniAl;
    }
}

