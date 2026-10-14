namespace OdevUygulama22
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbDugmeler = new GroupBox();
            btnSorgula = new Button();
            cbKombi = new CheckBox();
            cbLamba = new CheckBox();
            gbDurum = new GroupBox();
            lbSistemRaporu = new ListBox();
            gbDugmeler.SuspendLayout();
            gbDurum.SuspendLayout();
            SuspendLayout();
            // 
            // gbDugmeler
            // 
            gbDugmeler.Controls.Add(btnSorgula);
            gbDugmeler.Controls.Add(cbKombi);
            gbDugmeler.Controls.Add(cbLamba);
            gbDugmeler.Location = new Point(20, 14);
            gbDugmeler.Name = "gbDugmeler";
            gbDugmeler.Size = new Size(208, 200);
            gbDugmeler.TabIndex = 0;
            gbDugmeler.TabStop = false;
            gbDugmeler.Text = "Kontrol Paneli";
            // 
            // btnSorgula
            // 
            btnSorgula.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSorgula.Location = new Point(8, 135);
            btnSorgula.Name = "btnSorgula";
            btnSorgula.Size = new Size(196, 31);
            btnSorgula.TabIndex = 3;
            btnSorgula.Text = "Sistemi Kontrol Et";
            btnSorgula.UseVisualStyleBackColor = true;
            btnSorgula.Click += btnSorgula_Click;
            // 
            // cbKombi
            // 
            cbKombi.AutoSize = true;
            cbKombi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cbKombi.Location = new Point(23, 86);
            cbKombi.Name = "cbKombi";
            cbKombi.Size = new Size(167, 25);
            cbKombi.TabIndex = 1;
            cbKombi.Text = "Kombiyi Aç/Kapat";
            cbKombi.UseVisualStyleBackColor = true;
            // 
            // cbLamba
            // 
            cbLamba.AutoSize = true;
            cbLamba.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cbLamba.Location = new Point(23, 37);
            cbLamba.Name = "cbLamba";
            cbLamba.Size = new Size(168, 25);
            cbLamba.TabIndex = 2;
            cbLamba.Text = "Lambayı Aç/Kapat";
            cbLamba.UseVisualStyleBackColor = true;
            cbLamba.CheckedChanged += cbLamba_CheckedChanged;
            // 
            // gbDurum
            // 
            gbDurum.Controls.Add(lbSistemRaporu);
            gbDurum.Location = new Point(234, 14);
            gbDurum.Name = "gbDurum";
            gbDurum.Size = new Size(208, 200);
            gbDurum.TabIndex = 0;
            gbDurum.TabStop = false;
            gbDurum.Text = "Sistem Raporu";
            // 
            // lbSistemRaporu
            // 
            lbSistemRaporu.FormattingEnabled = true;
            lbSistemRaporu.ItemHeight = 15;
            lbSistemRaporu.Location = new Point(17, 19);
            lbSistemRaporu.Name = "lbSistemRaporu";
            lbSistemRaporu.Size = new Size(180, 169);
            lbSistemRaporu.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 253);
            Controls.Add(gbDurum);
            Controls.Add(gbDugmeler);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistem Kontrol Paneli";
            gbDugmeler.ResumeLayout(false);
            gbDugmeler.PerformLayout();
            gbDurum.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDugmeler;
        private CheckBox cbKombi;
        private CheckBox cbLamba;
        private GroupBox gbDurum;
        private ListBox lbSistemRaporu;
        private Button btnSorgula;
    }
}
