namespace MessageBoxNesnesi
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
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.btn_cikisYap = new System.Windows.Forms.Button();
            this.lbl_olumlu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(48, 41);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(52, 20);
            this.lbl_sonuc.TabIndex = 0;
            this.lbl_sonuc.Text = "Sonuç:";
            this.lbl_sonuc.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_cikisYap
            // 
            this.btn_cikisYap.Location = new System.Drawing.Point(48, 74);
            this.btn_cikisYap.Name = "btn_cikisYap";
            this.btn_cikisYap.Size = new System.Drawing.Size(118, 36);
            this.btn_cikisYap.TabIndex = 1;
            this.btn_cikisYap.Text = "Çıkış Yap";
            this.btn_cikisYap.UseVisualStyleBackColor = true;
            this.btn_cikisYap.Click += new System.EventHandler(this.btn_cikisYap_Click);
            // 
            // lbl_olumlu
            // 
            this.lbl_olumlu.AutoSize = true;
            this.lbl_olumlu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_olumlu.Location = new System.Drawing.Point(106, 41);
            this.lbl_olumlu.Name = "lbl_olumlu";
            this.lbl_olumlu.Size = new System.Drawing.Size(60, 20);
            this.lbl_olumlu.TabIndex = 0;
            this.lbl_olumlu.Text = "Olumlu";
            this.lbl_olumlu.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 176);
            this.Controls.Add(this.btn_cikisYap);
            this.Controls.Add(this.lbl_olumlu);
            this.Controls.Add(this.lbl_sonuc);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_sonuc;
        private Button btn_cikisYap;
        private Label lbl_olumlu;
    }
}