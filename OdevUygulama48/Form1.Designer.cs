namespace OdevUygulama48
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
            this.btnKareAl = new System.Windows.Forms.Button();
            this.txtKare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKareAl
            // 
            this.btnKareAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKareAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKareAl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKareAl.Location = new System.Drawing.Point(49, 127);
            this.btnKareAl.Name = "btnKareAl";
            this.btnKareAl.Size = new System.Drawing.Size(255, 56);
            this.btnKareAl.TabIndex = 0;
            this.btnKareAl.Text = "HESAPLA";
            this.btnKareAl.UseVisualStyleBackColor = false;
            this.btnKareAl.Click += new System.EventHandler(this.btnKareAl_Click);
            // 
            // txtKare
            // 
            this.txtKare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKare.Location = new System.Drawing.Point(49, 76);
            this.txtKare.Name = "txtKare";
            this.txtKare.Size = new System.Drawing.Size(257, 31);
            this.txtKare.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "KARESİ ALINACAK SAYI :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 222);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKare);
            this.Controls.Add(this.btnKareAl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Try-Catch-Finally";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKareAl;
        private System.Windows.Forms.TextBox txtKare;
        private System.Windows.Forms.Label label1;
    }
}

