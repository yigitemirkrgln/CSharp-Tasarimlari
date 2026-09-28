namespace YilanOyunu
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
            this.components = new System.ComponentModel.Container();
            this.lblSkor = new System.Windows.Forms.Label();
            this.pnlOyun = new System.Windows.Forms.Panel();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrOyun = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblSkor.Location = new System.Drawing.Point(316, 24);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(48, 26);
            this.lblSkor.TabIndex = 0;
            this.lblSkor.Text = "000";
            // 
            // pnlOyun
            // 
            this.pnlOyun.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlOyun.Location = new System.Drawing.Point(12, 53);
            this.pnlOyun.Name = "pnlOyun";
            this.pnlOyun.Size = new System.Drawing.Size(600, 600);
            this.pnlOyun.TabIndex = 1;
            this.pnlOyun.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOyun_Paint);
            // 
            // lblBilgi
            // 
            this.lblBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.Location = new System.Drawing.Point(12, 656);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(589, 53);
            this.lblBilgi.TabIndex = 2;
            this.lblBilgi.Text = "Herhangi bir yön tuşuna basarak oyunu başlatın ve yön tuşları ile yılanı yönlendi" +
    "rin";
            this.lblBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBilgi.Click += new System.EventHandler(this.lblBilgi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(247, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skor:";
            // 
            // tmrOyun
            // 
            this.tmrOyun.Interval = 500;
            this.tmrOyun.Tick += new System.EventHandler(this.tmrOyun_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 718);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.pnlOyun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSkor);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Panel pnlOyun;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrOyun;
    }
}

