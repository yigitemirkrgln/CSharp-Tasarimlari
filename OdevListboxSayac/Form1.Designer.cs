namespace OdevListboxSayac
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
            this.btnAktar = new System.Windows.Forms.Button();
            this.lbBir = new System.Windows.Forms.ListBox();
            this.lbIki = new System.Windows.Forms.ListBox();
            this.cmbIsimler = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAktar
            // 
            this.btnAktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAktar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAktar.Location = new System.Drawing.Point(23, 104);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(314, 51);
            this.btnAktar.TabIndex = 0;
            this.btnAktar.Text = "AKTAR";
            this.btnAktar.UseVisualStyleBackColor = false;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // lbBir
            // 
            this.lbBir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBir.FormattingEnabled = true;
            this.lbBir.ItemHeight = 24;
            this.lbBir.Location = new System.Drawing.Point(5, 12);
            this.lbBir.Name = "lbBir";
            this.lbBir.Size = new System.Drawing.Size(202, 412);
            this.lbBir.TabIndex = 1;
            // 
            // lbIki
            // 
            this.lbIki.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbIki.FormattingEnabled = true;
            this.lbIki.ItemHeight = 24;
            this.lbIki.Location = new System.Drawing.Point(586, 12);
            this.lbIki.Name = "lbIki";
            this.lbIki.Size = new System.Drawing.Size(202, 412);
            this.lbIki.TabIndex = 1;
            // 
            // cmbIsimler
            // 
            this.cmbIsimler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIsimler.FormattingEnabled = true;
            this.cmbIsimler.Items.AddRange(new object[] {
            ""});
            this.cmbIsimler.Location = new System.Drawing.Point(23, 24);
            this.cmbIsimler.Name = "cmbIsimler";
            this.cmbIsimler.Size = new System.Drawing.Size(314, 26);
            this.cmbIsimler.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbIsimler);
            this.groupBox1.Controls.Add(this.btnAktar);
            this.groupBox1.Location = new System.Drawing.Point(217, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 169);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktarma Bölümü";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEkle.Location = new System.Drawing.Point(14, 110);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(314, 51);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtGiris
            // 
            this.txtGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGiris.Location = new System.Drawing.Point(14, 39);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(314, 26);
            this.txtGiris.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "İsim Giriniz :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtGiris);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Location = new System.Drawing.Point(217, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 180);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekleme Bölümü";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbIki);
            this.Controls.Add(this.lbBir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.ListBox lbBir;
        private System.Windows.Forms.ListBox lbIki;
        private System.Windows.Forms.ComboBox cmbIsimler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

