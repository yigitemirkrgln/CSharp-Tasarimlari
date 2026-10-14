namespace OdevUygulama19
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
            label1 = new Label();
            label2 = new Label();
            txtSayi2 = new TextBox();
            txtSayi1 = new TextBox();
            btnHesapla = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 0;
            label1.Text = "2.Sayı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(12, 16);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 1;
            label2.Text = "1.Sayı";
            // 
            // txtSayi2
            // 
            txtSayi2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtSayi2.Location = new Point(117, 64);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(114, 33);
            txtSayi2.TabIndex = 2;
            // 
            // txtSayi1
            // 
            txtSayi1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtSayi1.Location = new Point(117, 16);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(114, 33);
            txtSayi1.TabIndex = 3;
            // 
            // btnHesapla
            // 
            btnHesapla.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnHesapla.Location = new Point(32, 131);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(305, 34);
            btnHesapla.TabIndex = 4;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(358, 202);
            Controls.Add(btnHesapla);
            Controls.Add(txtSayi1);
            Controls.Add(txtSayi2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sayı Büyüklük Hesaplama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSayi2;
        private TextBox txtSayi1;
        private Button btnHesapla;
    }
}
