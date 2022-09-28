namespace NotHesaplama2
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
            this.lbl_birinciNot = new System.Windows.Forms.Label();
            this.txt_birinciNot = new System.Windows.Forms.TextBox();
            this.lbl_ikinciNot = new System.Windows.Forms.Label();
            this.txt_ikinciNot = new System.Windows.Forms.TextBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.lbl_ortalama = new System.Windows.Forms.Label();
            this.lbl_ortalamaSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_birinciNot
            // 
            this.lbl_birinciNot.AutoSize = true;
            this.lbl_birinciNot.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_birinciNot.Location = new System.Drawing.Point(28, 21);
            this.lbl_birinciNot.Name = "lbl_birinciNot";
            this.lbl_birinciNot.Size = new System.Drawing.Size(156, 21);
            this.lbl_birinciNot.TabIndex = 0;
            this.lbl_birinciNot.Text = "1. Notunuzu Giriniz:";
            // 
            // txt_birinciNot
            // 
            this.txt_birinciNot.Location = new System.Drawing.Point(190, 15);
            this.txt_birinciNot.Name = "txt_birinciNot";
            this.txt_birinciNot.Size = new System.Drawing.Size(71, 27);
            this.txt_birinciNot.TabIndex = 0;
            // 
            // lbl_ikinciNot
            // 
            this.lbl_ikinciNot.AutoSize = true;
            this.lbl_ikinciNot.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ikinciNot.Location = new System.Drawing.Point(28, 80);
            this.lbl_ikinciNot.Name = "lbl_ikinciNot";
            this.lbl_ikinciNot.Size = new System.Drawing.Size(156, 21);
            this.lbl_ikinciNot.TabIndex = 0;
            this.lbl_ikinciNot.Text = "2. Notunuzu Giriniz:";
            // 
            // txt_ikinciNot
            // 
            this.txt_ikinciNot.Location = new System.Drawing.Point(190, 74);
            this.txt_ikinciNot.Name = "txt_ikinciNot";
            this.txt_ikinciNot.Size = new System.Drawing.Size(71, 27);
            this.txt_ikinciNot.TabIndex = 1;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(28, 129);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(94, 29);
            this.btn_hesapla.TabIndex = 2;
            this.btn_hesapla.Text = "HESAPLA";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // lbl_ortalama
            // 
            this.lbl_ortalama.AutoSize = true;
            this.lbl_ortalama.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ortalama.Location = new System.Drawing.Point(140, 129);
            this.lbl_ortalama.Name = "lbl_ortalama";
            this.lbl_ortalama.Size = new System.Drawing.Size(85, 23);
            this.lbl_ortalama.TabIndex = 3;
            this.lbl_ortalama.Text = "Ortalama:";
            // 
            // lbl_ortalamaSonuc
            // 
            this.lbl_ortalamaSonuc.AutoSize = true;
            this.lbl_ortalamaSonuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ortalamaSonuc.Location = new System.Drawing.Point(219, 129);
            this.lbl_ortalamaSonuc.Name = "lbl_ortalamaSonuc";
            this.lbl_ortalamaSonuc.Size = new System.Drawing.Size(20, 23);
            this.lbl_ortalamaSonuc.TabIndex = 3;
            this.lbl_ortalamaSonuc.Text = "0";
            this.lbl_ortalamaSonuc.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 221);
            this.Controls.Add(this.lbl_ortalamaSonuc);
            this.Controls.Add(this.lbl_ortalama);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.txt_ikinciNot);
            this.Controls.Add(this.txt_birinciNot);
            this.Controls.Add(this.lbl_ikinciNot);
            this.Controls.Add(this.lbl_birinciNot);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_birinciNot;
        private TextBox txt_birinciNot;
        private Label lbl_ikinciNot;
        private TextBox txt_ikinciNot;
        private Button btn_hesapla;
        private Label lbl_ortalama;
        private Label lbl_ortalamaSonuc;
    }
}