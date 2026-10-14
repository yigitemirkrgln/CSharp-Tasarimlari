namespace OdevUygulama26
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
            btnGunOgren = new Button();
            SuspendLayout();
            // 
            // btnGunOgren
            // 
            btnGunOgren.BackColor = Color.FromArgb(15, 157, 88);
            btnGunOgren.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGunOgren.ForeColor = Color.White;
            btnGunOgren.Location = new Point(24, 56);
            btnGunOgren.Name = "btnGunOgren";
            btnGunOgren.Size = new Size(309, 56);
            btnGunOgren.TabIndex = 0;
            btnGunOgren.Text = "Haftanın Hangi Günündeyim?";
            btnGunOgren.UseVisualStyleBackColor = false;
            btnGunOgren.Click += btnGunOgren_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(363, 180);
            Controls.Add(btnGunOgren);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gün Öğrenme Programı";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGunOgren;
    }
}
