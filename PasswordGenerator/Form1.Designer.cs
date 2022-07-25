
namespace PasswordGenerator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkKucukHarf = new System.Windows.Forms.CheckBox();
            this.chkBuyukHarf = new System.Windows.Forms.CheckBox();
            this.chkRakam = new System.Windows.Forms.CheckBox();
            this.chkOzelKarakter = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrSifreSayisi = new System.Windows.Forms.NumericUpDown();
            this.nmrSifreUzunlugu = new System.Windows.Forms.NumericUpDown();
            this.btnÜret = new System.Windows.Forms.Button();
            this.txtSifreler = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSifreSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSifreUzunlugu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnÜret);
            this.groupBox1.Controls.Add(this.nmrSifreSayisi);
            this.groupBox1.Controls.Add(this.nmrSifreUzunlugu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkOzelKarakter);
            this.groupBox1.Controls.Add(this.chkRakam);
            this.groupBox1.Controls.Add(this.chkBuyukHarf);
            this.groupBox1.Controls.Add(this.chkKucukHarf);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametreler";
            // 
            // chkKucukHarf
            // 
            this.chkKucukHarf.AutoSize = true;
            this.chkKucukHarf.Location = new System.Drawing.Point(10, 34);
            this.chkKucukHarf.Name = "chkKucukHarf";
            this.chkKucukHarf.Size = new System.Drawing.Size(80, 17);
            this.chkKucukHarf.TabIndex = 0;
            this.chkKucukHarf.Text = "Küçük Harf";
            this.chkKucukHarf.UseVisualStyleBackColor = true;
            // 
            // chkBuyukHarf
            // 
            this.chkBuyukHarf.AutoSize = true;
            this.chkBuyukHarf.Location = new System.Drawing.Point(10, 57);
            this.chkBuyukHarf.Name = "chkBuyukHarf";
            this.chkBuyukHarf.Size = new System.Drawing.Size(79, 17);
            this.chkBuyukHarf.TabIndex = 1;
            this.chkBuyukHarf.Text = "Büyük Harf";
            this.chkBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // chkRakam
            // 
            this.chkRakam.AutoSize = true;
            this.chkRakam.Location = new System.Drawing.Point(10, 80);
            this.chkRakam.Name = "chkRakam";
            this.chkRakam.Size = new System.Drawing.Size(60, 17);
            this.chkRakam.TabIndex = 2;
            this.chkRakam.Text = "Rakam";
            this.chkRakam.UseVisualStyleBackColor = true;
            // 
            // chkOzelKarakter
            // 
            this.chkOzelKarakter.AutoSize = true;
            this.chkOzelKarakter.Location = new System.Drawing.Point(10, 103);
            this.chkOzelKarakter.Name = "chkOzelKarakter";
            this.chkOzelKarakter.Size = new System.Drawing.Size(90, 17);
            this.chkOzelKarakter.TabIndex = 3;
            this.chkOzelKarakter.Text = "Özel Karakter";
            this.chkOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şifre Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre Uzunluğu:";
            // 
            // nmrSifreSayisi
            // 
            this.nmrSifreSayisi.Location = new System.Drawing.Point(109, 183);
            this.nmrSifreSayisi.Name = "nmrSifreSayisi";
            this.nmrSifreSayisi.Size = new System.Drawing.Size(120, 20);
            this.nmrSifreSayisi.TabIndex = 1;
            // 
            // nmrSifreUzunlugu
            // 
            this.nmrSifreUzunlugu.Location = new System.Drawing.Point(109, 213);
            this.nmrSifreUzunlugu.Name = "nmrSifreUzunlugu";
            this.nmrSifreUzunlugu.Size = new System.Drawing.Size(120, 20);
            this.nmrSifreUzunlugu.TabIndex = 2;
            // 
            // btnÜret
            // 
            this.btnÜret.Location = new System.Drawing.Point(10, 259);
            this.btnÜret.Name = "btnÜret";
            this.btnÜret.Size = new System.Drawing.Size(219, 29);
            this.btnÜret.TabIndex = 6;
            this.btnÜret.Text = "Üret";
            this.btnÜret.UseVisualStyleBackColor = true;
            this.btnÜret.Click += new System.EventHandler(this.btnÜret_Click);
            // 
            // txtSifreler
            // 
            this.txtSifreler.Location = new System.Drawing.Point(357, 13);
            this.txtSifreler.Multiline = true;
            this.txtSifreler.Name = "txtSifreler";
            this.txtSifreler.ReadOnly = true;
            this.txtSifreler.Size = new System.Drawing.Size(289, 362);
            this.txtSifreler.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 381);
            this.Controls.Add(this.txtSifreler);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSifreSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSifreUzunlugu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnÜret;
        private System.Windows.Forms.NumericUpDown nmrSifreSayisi;
        private System.Windows.Forms.NumericUpDown nmrSifreUzunlugu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkOzelKarakter;
        private System.Windows.Forms.CheckBox chkRakam;
        private System.Windows.Forms.CheckBox chkBuyukHarf;
        private System.Windows.Forms.CheckBox chkKucukHarf;
        private System.Windows.Forms.TextBox txtSifreler;
    }
}

