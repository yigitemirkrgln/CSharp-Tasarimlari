namespace OdevUygulama16
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
            this.gbBirinci = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatematikNet = new System.Windows.Forms.TextBox();
            this.txtMatematikYanlis = new System.Windows.Forms.TextBox();
            this.txtMatematikDogru = new System.Windows.Forms.TextBox();
            this.txtTurkceNet = new System.Windows.Forms.TextBox();
            this.txtTurkceYanlis = new System.Windows.Forms.TextBox();
            this.txtTurkceDogru = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.gbBirinci.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBirinci
            // 
            this.gbBirinci.Controls.Add(this.txtMatematikNet);
            this.gbBirinci.Controls.Add(this.txtMatematikYanlis);
            this.gbBirinci.Controls.Add(this.txtMatematikDogru);
            this.gbBirinci.Controls.Add(this.txtTurkceNet);
            this.gbBirinci.Controls.Add(this.txtTurkceYanlis);
            this.gbBirinci.Controls.Add(this.txtTurkceDogru);
            this.gbBirinci.Controls.Add(this.label5);
            this.gbBirinci.Controls.Add(this.label4);
            this.gbBirinci.Controls.Add(this.label3);
            this.gbBirinci.Controls.Add(this.label2);
            this.gbBirinci.Controls.Add(this.label1);
            this.gbBirinci.Location = new System.Drawing.Point(46, 40);
            this.gbBirinci.Name = "gbBirinci";
            this.gbBirinci.Size = new System.Drawing.Size(737, 247);
            this.gbBirinci.TabIndex = 0;
            this.gbBirinci.TabStop = false;
            this.gbBirinci.Text = "Sınav 1.Oturum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(648, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Net";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(475, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yanlış";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Türkçe (40 Soru) ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Matematik (40 Soru)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(310, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doğru";
            // 
            // txtMatematikNet
            // 
            this.txtMatematikNet.Location = new System.Drawing.Point(640, 145);
            this.txtMatematikNet.Name = "txtMatematikNet";
            this.txtMatematikNet.ReadOnly = true;
            this.txtMatematikNet.Size = new System.Drawing.Size(51, 20);
            this.txtMatematikNet.TabIndex = 1;
            // 
            // txtMatematikYanlis
            // 
            this.txtMatematikYanlis.Location = new System.Drawing.Point(478, 145);
            this.txtMatematikYanlis.Name = "txtMatematikYanlis";
            this.txtMatematikYanlis.Size = new System.Drawing.Size(51, 20);
            this.txtMatematikYanlis.TabIndex = 2;
            // 
            // txtMatematikDogru
            // 
            this.txtMatematikDogru.Location = new System.Drawing.Point(313, 147);
            this.txtMatematikDogru.Name = "txtMatematikDogru";
            this.txtMatematikDogru.Size = new System.Drawing.Size(51, 20);
            this.txtMatematikDogru.TabIndex = 3;
            // 
            // txtTurkceNet
            // 
            this.txtTurkceNet.Location = new System.Drawing.Point(640, 86);
            this.txtTurkceNet.Name = "txtTurkceNet";
            this.txtTurkceNet.ReadOnly = true;
            this.txtTurkceNet.Size = new System.Drawing.Size(51, 20);
            this.txtTurkceNet.TabIndex = 4;
            // 
            // txtTurkceYanlis
            // 
            this.txtTurkceYanlis.Location = new System.Drawing.Point(478, 86);
            this.txtTurkceYanlis.Name = "txtTurkceYanlis";
            this.txtTurkceYanlis.Size = new System.Drawing.Size(51, 20);
            this.txtTurkceYanlis.TabIndex = 5;
            // 
            // txtTurkceDogru
            // 
            this.txtTurkceDogru.Location = new System.Drawing.Point(313, 86);
            this.txtTurkceDogru.Name = "txtTurkceDogru";
            this.txtTurkceDogru.Size = new System.Drawing.Size(51, 20);
            this.txtTurkceDogru.TabIndex = 6;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(400, 293);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(284, 27);
            this.btnHesapla.TabIndex = 1;
            this.btnHesapla.Text = "NET HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(867, 367);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.gbBirinci);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Net Hesaplama";
            this.gbBirinci.ResumeLayout(false);
            this.gbBirinci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBirinci;
        private System.Windows.Forms.TextBox txtTurkceYanlis;
        private System.Windows.Forms.TextBox txtTurkceDogru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatematikNet;
        private System.Windows.Forms.TextBox txtMatematikYanlis;
        private System.Windows.Forms.TextBox txtMatematikDogru;
        private System.Windows.Forms.TextBox txtTurkceNet;
        private System.Windows.Forms.Button btnHesapla;
    }
}

