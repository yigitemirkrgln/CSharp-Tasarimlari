namespace OdevUygulama25
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
            btnSorgula = new Button();
            label1 = new Label();
            txtNotOrtalamasi = new TextBox();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // btnSorgula
            // 
            btnSorgula.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSorgula.Location = new Point(144, 97);
            btnSorgula.Name = "btnSorgula";
            btnSorgula.Size = new Size(226, 31);
            btnSorgula.TabIndex = 0;
            btnSorgula.Text = "Sorgula";
            btnSorgula.UseVisualStyleBackColor = true;
            btnSorgula.Click += btnSorgula_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(36, 43);
            label1.Name = "label1";
            label1.Size = new Size(175, 30);
            label1.TabIndex = 1;
            label1.Text = "Not Ortalaması :";
            // 
            // txtNotOrtalamasi
            // 
            txtNotOrtalamasi.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtNotOrtalamasi.Location = new Point(220, 43);
            txtNotOrtalamasi.Name = "txtNotOrtalamasi";
            txtNotOrtalamasi.Size = new Size(187, 35);
            txtNotOrtalamasi.TabIndex = 2;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSonuc.Location = new Point(36, 178);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 30);
            lblSonuc.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(499, 217);
            Controls.Add(lblSonuc);
            Controls.Add(txtNotOrtalamasi);
            Controls.Add(label1);
            Controls.Add(btnSorgula);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Belge İşlemleri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSorgula;
        private Label label1;
        private TextBox txtNotOrtalamasi;
        private Label lblSonuc;
    }
}
