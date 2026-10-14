namespace OdevUygulama17
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
            btnSonucuGoster = new Button();
            SuspendLayout();
            // 
            // btnSonucuGoster
            // 
            btnSonucuGoster.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSonucuGoster.Location = new Point(61, 61);
            btnSonucuGoster.Name = "btnSonucuGoster";
            btnSonucuGoster.Size = new Size(171, 81);
            btnSonucuGoster.TabIndex = 0;
            btnSonucuGoster.Text = "Sonucu Göster";
            btnSonucuGoster.UseVisualStyleBackColor = true;
            btnSonucuGoster.Click += btnSonucuGoster_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(295, 196);
            Controls.Add(btnSonucuGoster);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Takım Yarışması Sonuçları";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSonucuGoster;
    }
}
