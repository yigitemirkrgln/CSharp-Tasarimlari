namespace OdevUygulama20
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
            txtSayi = new TextBox();
            SuspendLayout();
            // 
            // btnSorgula
            // 
            btnSorgula.Location = new Point(122, 113);
            btnSorgula.Name = "btnSorgula";
            btnSorgula.Size = new Size(163, 41);
            btnSorgula.TabIndex = 0;
            btnSorgula.Text = "Sorgula";
            btnSorgula.UseVisualStyleBackColor = true;
            btnSorgula.Click += btnSorgula_Click;
            // 
            // txtSayi
            // 
            txtSayi.Location = new Point(23, 49);
            txtSayi.Name = "txtSayi";
            txtSayi.Size = new Size(383, 23);
            txtSayi.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkViolet;
            ClientSize = new Size(432, 239);
            Controls.Add(txtSayi);
            Controls.Add(btnSorgula);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tek mi Çift mi?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSorgula;
        private TextBox txtSayi;
    }
}
