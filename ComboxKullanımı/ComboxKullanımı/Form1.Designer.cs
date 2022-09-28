namespace ComboxKullanımı
{
    partial class combo_gunler
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_gunSec = new System.Windows.Forms.Button();
            this.lbl_gunSec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe",
            "Cuma"});
            this.comboBox1.Location = new System.Drawing.Point(130, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // btn_gunSec
            // 
            this.btn_gunSec.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_gunSec.Location = new System.Drawing.Point(26, 87);
            this.btn_gunSec.Name = "btn_gunSec";
            this.btn_gunSec.Size = new System.Drawing.Size(246, 39);
            this.btn_gunSec.TabIndex = 1;
            this.btn_gunSec.Text = "Gün Seç";
            this.btn_gunSec.UseVisualStyleBackColor = true;
            this.btn_gunSec.Click += new System.EventHandler(this.btn_gunSec_Click);
            // 
            // lbl_gunSec
            // 
            this.lbl_gunSec.AutoSize = true;
            this.lbl_gunSec.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_gunSec.Location = new System.Drawing.Point(26, 39);
            this.lbl_gunSec.Name = "lbl_gunSec";
            this.lbl_gunSec.Size = new System.Drawing.Size(103, 23);
            this.lbl_gunSec.TabIndex = 2;
            this.lbl_gunSec.Text = "Gün Seçiniz:";
            // 
            // combo_gunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 210);
            this.Controls.Add(this.lbl_gunSec);
            this.Controls.Add(this.btn_gunSec);
            this.Controls.Add(this.comboBox1);
            this.Name = "combo_gunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Button btn_gunSec;
        private Label lbl_gunSec;
    }
}