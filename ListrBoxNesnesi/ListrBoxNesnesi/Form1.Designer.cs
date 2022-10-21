namespace ListrBoxNesnesi
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
            this.lbl_degerGir = new System.Windows.Forms.Label();
            this.txt_degerGir = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_countBul = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_degerGir
            // 
            this.lbl_degerGir.AutoSize = true;
            this.lbl_degerGir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_degerGir.Location = new System.Drawing.Point(12, 29);
            this.lbl_degerGir.Name = "lbl_degerGir";
            this.lbl_degerGir.Size = new System.Drawing.Size(234, 20);
            this.lbl_degerGir.TabIndex = 0;
            this.lbl_degerGir.Text = "Eklemek İstediğiniz Değeri Giriniz:";
            // 
            // txt_degerGir
            // 
            this.txt_degerGir.AutoCompleteCustomSource.AddRange(new string[] {
            "Perşembe"});
            this.txt_degerGir.Location = new System.Drawing.Point(252, 26);
            this.txt_degerGir.Name = "txt_degerGir";
            this.txt_degerGir.Size = new System.Drawing.Size(125, 27);
            this.txt_degerGir.TabIndex = 1;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ekle.Location = new System.Drawing.Point(252, 75);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(125, 28);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sil.Location = new System.Drawing.Point(252, 125);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(125, 28);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_countBul
            // 
            this.btn_countBul.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_countBul.Location = new System.Drawing.Point(252, 176);
            this.btn_countBul.Name = "btn_countBul";
            this.btn_countBul.Size = new System.Drawing.Size(125, 28);
            this.btn_countBul.TabIndex = 2;
            this.btn_countBul.Text = "Count Bul";
            this.btn_countBul.UseVisualStyleBackColor = true;
            this.btn_countBul.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_temizle.Location = new System.Drawing.Point(252, 231);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(125, 28);
            this.btn_temizle.TabIndex = 2;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe"});
            this.listBox1.Location = new System.Drawing.Point(24, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 184);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 335);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_countBul);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_degerGir);
            this.Controls.Add(this.lbl_degerGir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_degerGir;
        private TextBox txt_degerGir;
        private Button btn_ekle;
        private Button btn_sil;
        private Button btn_countBul;
        private Button btn_temizle;
        private ListBox listBox1;
    }
}