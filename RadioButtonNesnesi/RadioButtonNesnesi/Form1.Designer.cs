namespace RadioButtonNesnesi
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
            this.lbl_ad = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.radio_kadin = new System.Windows.Forms.RadioButton();
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.radio_erkek = new System.Windows.Forms.RadioButton();
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ad.Location = new System.Drawing.Point(12, 22);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(61, 23);
            this.lbl_ad.TabIndex = 0;
            this.lbl_ad.Text = "Adınız:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(140, 18);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(125, 27);
            this.txt_ad.TabIndex = 0;
            this.txt_ad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_soyad.Location = new System.Drawing.Point(13, 64);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(86, 23);
            this.lbl_soyad.TabIndex = 0;
            this.lbl_soyad.Text = "Soyadınız:";
            this.lbl_soyad.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(140, 63);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(125, 27);
            this.txt_soyad.TabIndex = 1;
            this.txt_soyad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radio_kadin
            // 
            this.radio_kadin.AutoSize = true;
            this.radio_kadin.Location = new System.Drawing.Point(137, 113);
            this.radio_kadin.Name = "radio_kadin";
            this.radio_kadin.Size = new System.Drawing.Size(68, 24);
            this.radio_kadin.TabIndex = 2;
            this.radio_kadin.TabStop = true;
            this.radio_kadin.Text = "Kadın";
            this.radio_kadin.UseVisualStyleBackColor = true;
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cinsiyet.Location = new System.Drawing.Point(13, 114);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(99, 23);
            this.lbl_cinsiyet.TabIndex = 0;
            this.lbl_cinsiyet.Text = "Cinsiyetiniz:";
            // 
            // radio_erkek
            // 
            this.radio_erkek.AutoSize = true;
            this.radio_erkek.Location = new System.Drawing.Point(211, 113);
            this.radio_erkek.Name = "radio_erkek";
            this.radio_erkek.Size = new System.Drawing.Size(65, 24);
            this.radio_erkek.TabIndex = 3;
            this.radio_erkek.TabStop = true;
            this.radio_erkek.Text = "Erkek";
            this.radio_erkek.UseVisualStyleBackColor = true;
            this.radio_erkek.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_yazdir.Location = new System.Drawing.Point(137, 154);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(128, 30);
            this.btn_yazdir.TabIndex = 4;
            this.btn_yazdir.Text = "Yazdır";
            this.btn_yazdir.UseVisualStyleBackColor = true;
            this.btn_yazdir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 260);
            this.Controls.Add(this.btn_yazdir);
            this.Controls.Add(this.radio_erkek);
            this.Controls.Add(this.radio_kadin);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.lbl_cinsiyet);
            this.Controls.Add(this.lbl_ad);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_ad;
        private TextBox txt_ad;
        private Label lbl_soyad;
        private TextBox txt_soyad;
        private RadioButton radio_kadin;
        private Label lbl_cinsiyet;
        private RadioButton radio_erkek;
        private Button btn_yazdir;
    }
}