namespace KareAlanCevreClass
{
    partial class Anaform
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
            this.btnDaire = new System.Windows.Forms.Button();
            this.btnDikdortgen = new System.Windows.Forms.Button();
            this.btnDikdortgenPrizma = new System.Windows.Forms.Button();
            this.btnKare = new System.Windows.Forms.Button();
            this.btnKup = new System.Windows.Forms.Button();
            this.btnUcgen = new System.Windows.Forms.Button();
            this.btnUcgenPrizma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDaire
            // 
            this.btnDaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDaire.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDaire.Location = new System.Drawing.Point(48, 47);
            this.btnDaire.Name = "btnDaire";
            this.btnDaire.Size = new System.Drawing.Size(232, 77);
            this.btnDaire.TabIndex = 0;
            this.btnDaire.Text = "DAİRE";
            this.btnDaire.UseVisualStyleBackColor = false;
            this.btnDaire.Click += new System.EventHandler(this.btnDaire_Click);
            // 
            // btnDikdortgen
            // 
            this.btnDikdortgen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDikdortgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDikdortgen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDikdortgen.Location = new System.Drawing.Point(48, 163);
            this.btnDikdortgen.Name = "btnDikdortgen";
            this.btnDikdortgen.Size = new System.Drawing.Size(232, 77);
            this.btnDikdortgen.TabIndex = 0;
            this.btnDikdortgen.Text = "DİKDÖRTGEN";
            this.btnDikdortgen.UseVisualStyleBackColor = false;
            this.btnDikdortgen.Click += new System.EventHandler(this.btnDikdortgen_Click);
            // 
            // btnDikdortgenPrizma
            // 
            this.btnDikdortgenPrizma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDikdortgenPrizma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDikdortgenPrizma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDikdortgenPrizma.Location = new System.Drawing.Point(48, 278);
            this.btnDikdortgenPrizma.Name = "btnDikdortgenPrizma";
            this.btnDikdortgenPrizma.Size = new System.Drawing.Size(232, 75);
            this.btnDikdortgenPrizma.TabIndex = 0;
            this.btnDikdortgenPrizma.Text = "DİKDÖRTGEN PRİZMA";
            this.btnDikdortgenPrizma.UseVisualStyleBackColor = false;
            this.btnDikdortgenPrizma.Click += new System.EventHandler(this.btnDikdortgenPrizma_Click);
            // 
            // btnKare
            // 
            this.btnKare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKare.Location = new System.Drawing.Point(308, 49);
            this.btnKare.Name = "btnKare";
            this.btnKare.Size = new System.Drawing.Size(232, 75);
            this.btnKare.TabIndex = 0;
            this.btnKare.Text = "KARE";
            this.btnKare.UseVisualStyleBackColor = false;
            this.btnKare.Click += new System.EventHandler(this.btnKare_Click);
            // 
            // btnKup
            // 
            this.btnKup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKup.Location = new System.Drawing.Point(308, 165);
            this.btnKup.Name = "btnKup";
            this.btnKup.Size = new System.Drawing.Size(232, 75);
            this.btnKup.TabIndex = 0;
            this.btnKup.Text = "KÜP";
            this.btnKup.UseVisualStyleBackColor = false;
            this.btnKup.Click += new System.EventHandler(this.btnKup_Click);
            // 
            // btnUcgen
            // 
            this.btnUcgen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUcgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUcgen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUcgen.Location = new System.Drawing.Point(308, 278);
            this.btnUcgen.Name = "btnUcgen";
            this.btnUcgen.Size = new System.Drawing.Size(232, 75);
            this.btnUcgen.TabIndex = 0;
            this.btnUcgen.Text = "ÜÇGEN";
            this.btnUcgen.UseVisualStyleBackColor = false;
            this.btnUcgen.Click += new System.EventHandler(this.btnUcgen_Click);
            // 
            // btnUcgenPrizma
            // 
            this.btnUcgenPrizma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUcgenPrizma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUcgenPrizma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUcgenPrizma.Location = new System.Drawing.Point(566, 49);
            this.btnUcgenPrizma.Name = "btnUcgenPrizma";
            this.btnUcgenPrizma.Size = new System.Drawing.Size(232, 77);
            this.btnUcgenPrizma.TabIndex = 0;
            this.btnUcgenPrizma.Text = "ÜÇGEN PRİZMA";
            this.btnUcgenPrizma.UseVisualStyleBackColor = false;
            this.btnUcgenPrizma.Click += new System.EventHandler(this.btnUcgenPrizma_Click);
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(835, 388);
            this.Controls.Add(this.btnUcgen);
            this.Controls.Add(this.btnKup);
            this.Controls.Add(this.btnUcgenPrizma);
            this.Controls.Add(this.btnDikdortgenPrizma);
            this.Controls.Add(this.btnKare);
            this.Controls.Add(this.btnDikdortgen);
            this.Controls.Add(this.btnDaire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Anaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelişmiş Hesaplama Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDaire;
        private System.Windows.Forms.Button btnDikdortgen;
        private System.Windows.Forms.Button btnDikdortgenPrizma;
        private System.Windows.Forms.Button btnKare;
        private System.Windows.Forms.Button btnKup;
        private System.Windows.Forms.Button btnUcgen;
        private System.Windows.Forms.Button btnUcgenPrizma;
    }
}

