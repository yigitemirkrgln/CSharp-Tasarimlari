namespace OdevAtYarisi
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
            this.pbBitis = new System.Windows.Forms.PictureBox();
            this.pbAt3 = new System.Windows.Forms.PictureBox();
            this.pbAt2 = new System.Windows.Forms.PictureBox();
            this.pbAt1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBitis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBitis
            // 
            this.pbBitis.BackColor = System.Drawing.Color.Red;
            this.pbBitis.Location = new System.Drawing.Point(1091, 0);
            this.pbBitis.Name = "pbBitis";
            this.pbBitis.Size = new System.Drawing.Size(45, 473);
            this.pbBitis.TabIndex = 1;
            this.pbBitis.TabStop = false;
            // 
            // pbAt3
            // 
            this.pbAt3.Image = global::OdevAtYarisi.Properties.Resources.Horse_gif_slow;
            this.pbAt3.Location = new System.Drawing.Point(12, 361);
            this.pbAt3.Name = "pbAt3";
            this.pbAt3.Size = new System.Drawing.Size(100, 50);
            this.pbAt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt3.TabIndex = 0;
            this.pbAt3.TabStop = false;
            // 
            // pbAt2
            // 
            this.pbAt2.Image = global::OdevAtYarisi.Properties.Resources.Horse_gif_slow;
            this.pbAt2.Location = new System.Drawing.Point(12, 187);
            this.pbAt2.Name = "pbAt2";
            this.pbAt2.Size = new System.Drawing.Size(100, 50);
            this.pbAt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt2.TabIndex = 0;
            this.pbAt2.TabStop = false;
            // 
            // pbAt1
            // 
            this.pbAt1.Image = global::OdevAtYarisi.Properties.Resources.Horse_gif_slow;
            this.pbAt1.Location = new System.Drawing.Point(12, 36);
            this.pbAt1.Name = "pbAt1";
            this.pbAt1.Size = new System.Drawing.Size(100, 50);
            this.pbAt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt1.TabIndex = 0;
            this.pbAt1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(178, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(760, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "YARIŞI BAŞLAT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1134, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbBitis);
            this.Controls.Add(this.pbAt3);
            this.Controls.Add(this.pbAt2);
            this.Controls.Add(this.pbAt1);
            this.Name = "Form1";
            this.Text = "At Yarışı Oyunu (AYO)";
            ((System.ComponentModel.ISupportInitialize)(this.pbBitis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAt1;
        private System.Windows.Forms.PictureBox pbAt2;
        private System.Windows.Forms.PictureBox pbAt3;
        private System.Windows.Forms.PictureBox pbBitis;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

