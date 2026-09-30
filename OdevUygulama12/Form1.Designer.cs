namespace OdevUygulama12
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
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbToplama = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCikarma1 = new System.Windows.Forms.TextBox();
            this.txtCikarma2 = new System.Windows.Forms.TextBox();
            this.txtCikarmaSonuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCikarma = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCarpmaSonuc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCarp2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCarp1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCarp = new System.Windows.Forms.Button();
            this.txtBol2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBol1 = new System.Windows.Forms.TextBox();
            this.txtBolmeSonuc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBolme = new System.Windows.Forms.Button();
            this.gbToplama.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(121, 33);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 0;
            this.txtSayi1.TextChanged += new System.EventHandler(this.txtSayi1_TextChanged);
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(121, 74);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 0;
            this.txtSayi2.TextChanged += new System.EventHandler(this.txtSayi2_TextChanged);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(121, 119);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ReadOnly = true;
            this.txtSonuc.Size = new System.Drawing.Size(100, 20);
            this.txtSonuc.TabIndex = 0;
            this.txtSonuc.TextChanged += new System.EventHandler(this.txtSonuc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Birinci Sayı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sonuç :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "İkinci Sayı :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(51, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Topla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbToplama
            // 
            this.gbToplama.Controls.Add(this.button1);
            this.gbToplama.Controls.Add(this.label4);
            this.gbToplama.Controls.Add(this.label2);
            this.gbToplama.Controls.Add(this.label1);
            this.gbToplama.Controls.Add(this.txtSonuc);
            this.gbToplama.Controls.Add(this.txtSayi2);
            this.gbToplama.Controls.Add(this.txtSayi1);
            this.gbToplama.Location = new System.Drawing.Point(9, 11);
            this.gbToplama.Name = "gbToplama";
            this.gbToplama.Size = new System.Drawing.Size(290, 224);
            this.gbToplama.TabIndex = 3;
            this.gbToplama.TabStop = false;
            this.gbToplama.Text = "Toplama İşlemi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCikarma);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCikarma1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCikarma2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCikarmaSonuc);
            this.groupBox1.Location = new System.Drawing.Point(336, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 222);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çıkarma";
            // 
            // txtCikarma1
            // 
            this.txtCikarma1.Location = new System.Drawing.Point(126, 25);
            this.txtCikarma1.Name = "txtCikarma1";
            this.txtCikarma1.Size = new System.Drawing.Size(100, 20);
            this.txtCikarma1.TabIndex = 0;
            this.txtCikarma1.TextChanged += new System.EventHandler(this.txtSayi1_TextChanged);
            // 
            // txtCikarma2
            // 
            this.txtCikarma2.Location = new System.Drawing.Point(126, 66);
            this.txtCikarma2.Name = "txtCikarma2";
            this.txtCikarma2.Size = new System.Drawing.Size(100, 20);
            this.txtCikarma2.TabIndex = 0;
            this.txtCikarma2.TextChanged += new System.EventHandler(this.txtSayi2_TextChanged);
            // 
            // txtCikarmaSonuc
            // 
            this.txtCikarmaSonuc.Location = new System.Drawing.Point(126, 111);
            this.txtCikarmaSonuc.Name = "txtCikarmaSonuc";
            this.txtCikarmaSonuc.ReadOnly = true;
            this.txtCikarmaSonuc.Size = new System.Drawing.Size(100, 20);
            this.txtCikarmaSonuc.TabIndex = 0;
            this.txtCikarmaSonuc.TextChanged += new System.EventHandler(this.txtSonuc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Birinci Sayı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(45, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sonuç :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(16, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "İkinci Sayı :";
            // 
            // btnCikarma
            // 
            this.btnCikarma.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCikarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikarma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCikarma.Location = new System.Drawing.Point(56, 152);
            this.btnCikarma.Name = "btnCikarma";
            this.btnCikarma.Size = new System.Drawing.Size(193, 33);
            this.btnCikarma.TabIndex = 2;
            this.btnCikarma.Text = "Çıkar";
            this.btnCikarma.UseVisualStyleBackColor = false;
            this.btnCikarma.Click += new System.EventHandler(this.btnCikarma_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCarp);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCarpmaSonuc);
            this.groupBox2.Controls.Add(this.txtCarp1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCarp2);
            this.groupBox2.Location = new System.Drawing.Point(685, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 221);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çarpma";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBolme);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtBol2);
            this.groupBox3.Controls.Add(this.txtBolmeSonuc);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtBol1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(1047, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 221);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bölme";
            // 
            // txtCarpmaSonuc
            // 
            this.txtCarpmaSonuc.Location = new System.Drawing.Point(129, 111);
            this.txtCarpmaSonuc.Name = "txtCarpmaSonuc";
            this.txtCarpmaSonuc.ReadOnly = true;
            this.txtCarpmaSonuc.Size = new System.Drawing.Size(100, 20);
            this.txtCarpmaSonuc.TabIndex = 0;
            this.txtCarpmaSonuc.TextChanged += new System.EventHandler(this.txtSonuc_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(13, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Birinci Sayı :";
            // 
            // txtCarp2
            // 
            this.txtCarp2.Location = new System.Drawing.Point(129, 66);
            this.txtCarp2.Name = "txtCarp2";
            this.txtCarp2.Size = new System.Drawing.Size(100, 20);
            this.txtCarp2.TabIndex = 0;
            this.txtCarp2.TextChanged += new System.EventHandler(this.txtSayi2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(48, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Sonuç :";
            // 
            // txtCarp1
            // 
            this.txtCarp1.Location = new System.Drawing.Point(129, 25);
            this.txtCarp1.Name = "txtCarp1";
            this.txtCarp1.Size = new System.Drawing.Size(100, 20);
            this.txtCarp1.TabIndex = 0;
            this.txtCarp1.TextChanged += new System.EventHandler(this.txtSayi1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(19, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "İkinci Sayı :";
            // 
            // btnCarp
            // 
            this.btnCarp.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCarp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCarp.Location = new System.Drawing.Point(59, 152);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(193, 33);
            this.btnCarp.TabIndex = 2;
            this.btnCarp.Text = "Çarp";
            this.btnCarp.UseVisualStyleBackColor = false;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // txtBol2
            // 
            this.txtBol2.Location = new System.Drawing.Point(135, 64);
            this.txtBol2.Name = "txtBol2";
            this.txtBol2.Size = new System.Drawing.Size(100, 20);
            this.txtBol2.TabIndex = 0;
            this.txtBol2.TextChanged += new System.EventHandler(this.txtSayi2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(54, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Sonuç :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(19, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Birinci Sayı :";
            // 
            // txtBol1
            // 
            this.txtBol1.Location = new System.Drawing.Point(135, 23);
            this.txtBol1.Name = "txtBol1";
            this.txtBol1.Size = new System.Drawing.Size(100, 20);
            this.txtBol1.TabIndex = 0;
            this.txtBol1.TextChanged += new System.EventHandler(this.txtSayi1_TextChanged);
            // 
            // txtBolmeSonuc
            // 
            this.txtBolmeSonuc.Location = new System.Drawing.Point(135, 109);
            this.txtBolmeSonuc.Name = "txtBolmeSonuc";
            this.txtBolmeSonuc.ReadOnly = true;
            this.txtBolmeSonuc.Size = new System.Drawing.Size(100, 20);
            this.txtBolmeSonuc.TabIndex = 0;
            this.txtBolmeSonuc.TextChanged += new System.EventHandler(this.txtSonuc_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(25, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "İkinci Sayı :";
            // 
            // btnBolme
            // 
            this.btnBolme.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBolme.Location = new System.Drawing.Point(65, 150);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(193, 33);
            this.btnBolme.TabIndex = 2;
            this.btnBolme.Text = "Böl";
            this.btnBolme.UseVisualStyleBackColor = false;
            this.btnBolme.Click += new System.EventHandler(this.btnBolme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1409, 245);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbToplama);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basit Toplama İşlemleri";
            this.gbToplama.ResumeLayout(false);
            this.gbToplama.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbToplama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCikarma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCikarma1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCikarma2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCikarmaSonuc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCarpmaSonuc;
        private System.Windows.Forms.TextBox txtCarp1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCarp2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBolme;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBol2;
        private System.Windows.Forms.TextBox txtBolmeSonuc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBol1;
        private System.Windows.Forms.Label label11;
    }
}

