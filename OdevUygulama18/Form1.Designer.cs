namespace OdevUygulama18
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
            txtYas = new TextBox();
            btnSorgula = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 30);
            label1.TabIndex = 0;
            label1.Text = "Yaşınızı Giriniz";
            // 
            // txtYas
            // 
            txtYas.Location = new Point(52, 52);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(155, 23);
            txtYas.TabIndex = 1;
            // 
            // btnSorgula
            // 
            btnSorgula.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSorgula.Location = new Point(78, 99);
            btnSorgula.Name = "btnSorgula";
            btnSorgula.Size = new Size(101, 33);
            btnSorgula.TabIndex = 2;
            btnSorgula.Text = "Sorgula";
            btnSorgula.UseVisualStyleBackColor = true;
            btnSorgula.Click += btnSorgula_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(255, 164);
            Controls.Add(btnSorgula);
            Controls.Add(txtYas);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ehliyet Yaş Sorgusu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtYas;
        private Button btnSorgula;
    }
}
