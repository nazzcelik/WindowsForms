namespace CheckBoxNesnesi
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
            this.checkBox_cay = new System.Windows.Forms.CheckBox();
            this.checkBox_kahve = new System.Windows.Forms.CheckBox();
            this.checkBox_hambrgr = new System.Windows.Forms.CheckBox();
            this.checkBox_pizza = new System.Windows.Forms.CheckBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.lbl_tutar = new System.Windows.Forms.Label();
            this.lbl_tutarDeger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox_cay
            // 
            this.checkBox_cay.AutoSize = true;
            this.checkBox_cay.Location = new System.Drawing.Point(22, 38);
            this.checkBox_cay.Name = "checkBox_cay";
            this.checkBox_cay.Size = new System.Drawing.Size(85, 24);
            this.checkBox_cay.TabIndex = 0;
            this.checkBox_cay.Text = "Çay: 8TL";
            this.checkBox_cay.UseVisualStyleBackColor = true;
            // 
            // checkBox_kahve
            // 
            this.checkBox_kahve.AutoSize = true;
            this.checkBox_kahve.Location = new System.Drawing.Point(22, 68);
            this.checkBox_kahve.Name = "checkBox_kahve";
            this.checkBox_kahve.Size = new System.Drawing.Size(109, 24);
            this.checkBox_kahve.TabIndex = 0;
            this.checkBox_kahve.Text = "Kahve: 14TL";
            this.checkBox_kahve.UseVisualStyleBackColor = true;
            // 
            // checkBox_hambrgr
            // 
            this.checkBox_hambrgr.AutoSize = true;
            this.checkBox_hambrgr.Location = new System.Drawing.Point(22, 98);
            this.checkBox_hambrgr.Name = "checkBox_hambrgr";
            this.checkBox_hambrgr.Size = new System.Drawing.Size(145, 24);
            this.checkBox_hambrgr.TabIndex = 0;
            this.checkBox_hambrgr.Text = "Hamburger: 40TL";
            this.checkBox_hambrgr.UseVisualStyleBackColor = true;
            // 
            // checkBox_pizza
            // 
            this.checkBox_pizza.AutoSize = true;
            this.checkBox_pizza.Location = new System.Drawing.Point(22, 128);
            this.checkBox_pizza.Name = "checkBox_pizza";
            this.checkBox_pizza.Size = new System.Drawing.Size(103, 24);
            this.checkBox_pizza.TabIndex = 0;
            this.checkBox_pizza.Text = "Pizza: 35TL";
            this.checkBox_pizza.UseVisualStyleBackColor = true;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_hesapla.Location = new System.Drawing.Point(22, 158);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(145, 33);
            this.btn_hesapla.TabIndex = 1;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_tutar
            // 
            this.lbl_tutar.AutoSize = true;
            this.lbl_tutar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tutar.Location = new System.Drawing.Point(22, 210);
            this.lbl_tutar.Name = "lbl_tutar";
            this.lbl_tutar.Size = new System.Drawing.Size(65, 25);
            this.lbl_tutar.TabIndex = 2;
            this.lbl_tutar.Text = "Tutar:";
            // 
            // lbl_tutarDeger
            // 
            this.lbl_tutarDeger.AutoSize = true;
            this.lbl_tutarDeger.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tutarDeger.Location = new System.Drawing.Point(84, 210);
            this.lbl_tutarDeger.Name = "lbl_tutarDeger";
            this.lbl_tutarDeger.Size = new System.Drawing.Size(49, 25);
            this.lbl_tutarDeger.TabIndex = 2;
            this.lbl_tutarDeger.Text = "0 TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 313);
            this.Controls.Add(this.lbl_tutarDeger);
            this.Controls.Add(this.lbl_tutar);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.checkBox_pizza);
            this.Controls.Add(this.checkBox_hambrgr);
            this.Controls.Add(this.checkBox_kahve);
            this.Controls.Add(this.checkBox_cay);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkBox_cay;
        private CheckBox checkBox_kahve;
        private CheckBox checkBox_hambrgr;
        private CheckBox checkBox_pizza;
        private Button btn_hesapla;
        private Label lbl_tutar;
        private Label lbl_tutarDeger;
    }
}