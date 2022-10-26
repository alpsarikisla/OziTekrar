namespace OziTekrar
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.tb_soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_dogumyili = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(117, 31);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(166, 20);
            this.tb_isim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim:";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(34, 250);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(35, 13);
            this.lbl_sonuc.TabIndex = 2;
            this.lbl_sonuc.Text = "label2";
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.Location = new System.Drawing.Point(208, 113);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(75, 23);
            this.btn_yazdir.TabIndex = 3;
            this.btn_yazdir.Text = "Yazdır";
            this.btn_yazdir.UseVisualStyleBackColor = true;
            this.btn_yazdir.Click += new System.EventHandler(this.btn_yazdir_Click);
            // 
            // tb_soyad
            // 
            this.tb_soyad.Location = new System.Drawing.Point(117, 57);
            this.tb_soyad.Name = "tb_soyad";
            this.tb_soyad.Size = new System.Drawing.Size(166, 20);
            this.tb_soyad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyisim:";
            // 
            // tb_dogumyili
            // 
            this.tb_dogumyili.Location = new System.Drawing.Point(117, 83);
            this.tb_dogumyili.Name = "tb_dogumyili";
            this.tb_dogumyili.Size = new System.Drawing.Size(166, 20);
            this.tb_dogumyili.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Doğum Yılı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 511);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_dogumyili);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_soyad);
            this.Controls.Add(this.btn_yazdir);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_isim);
            this.Name = "Form1";
            this.Text = "Sanada Selam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Button btn_yazdir;
        private System.Windows.Forms.TextBox tb_soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_dogumyili;
        private System.Windows.Forms.Label label3;
    }
}

