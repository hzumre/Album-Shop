namespace PlakDukkani.UI
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
            this.btnKayıtOlustur = new System.Windows.Forms.Button();
            this.rdbKadin = new System.Windows.Forms.RadioButton();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.lblSifreTekrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKayıtOlustur
            // 
            this.btnKayıtOlustur.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKayıtOlustur.Location = new System.Drawing.Point(185, 273);
            this.btnKayıtOlustur.Name = "btnKayıtOlustur";
            this.btnKayıtOlustur.Size = new System.Drawing.Size(258, 36);
            this.btnKayıtOlustur.TabIndex = 24;
            this.btnKayıtOlustur.Text = "Kayıt Oluştur";
            this.btnKayıtOlustur.UseVisualStyleBackColor = true;
            this.btnKayıtOlustur.Click += new System.EventHandler(this.btnKayıtOlustur_Click);
            // 
            // rdbKadin
            // 
            this.rdbKadin.AutoSize = true;
            this.rdbKadin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbKadin.Location = new System.Drawing.Point(299, 225);
            this.rdbKadin.Name = "rdbKadin";
            this.rdbKadin.Size = new System.Drawing.Size(70, 24);
            this.rdbKadin.TabIndex = 23;
            this.rdbKadin.TabStop = true;
            this.rdbKadin.Text = "Kadın";
            this.rdbKadin.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbErkek.Location = new System.Drawing.Point(197, 225);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(68, 24);
            this.rdbErkek.TabIndex = 22;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(185, 120);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '.';
            this.txtSifre.Size = new System.Drawing.Size(246, 27);
            this.txtSifre.TabIndex = 18;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(185, 76);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(246, 27);
            this.txtKullaniciAdi.TabIndex = 17;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(185, 28);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(246, 27);
            this.txtAd.TabIndex = 16;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.BackColor = System.Drawing.Color.Silver;
            this.lblCinsiyet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCinsiyet.Location = new System.Drawing.Point(69, 212);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(110, 37);
            this.lblCinsiyet.TabIndex = 31;
            this.lblCinsiyet.Text = "Cinsiyet :";
            // 
            // lblSifre
            // 
            this.lblSifre.BackColor = System.Drawing.Color.Silver;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSifre.Location = new System.Drawing.Point(102, 120);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(77, 34);
            this.lblSifre.TabIndex = 27;
            this.lblSifre.Text = "Şifre :";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Silver;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAdi.Location = new System.Drawing.Point(31, 72);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(148, 34);
            this.lblKullaniciAdi.TabIndex = 26;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // lblAd
            // 
            this.lblAd.BackColor = System.Drawing.Color.Silver;
            this.lblAd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAd.Location = new System.Drawing.Point(69, 28);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(110, 34);
            this.lblAd.TabIndex = 25;
            this.lblAd.Text = "Ad Soyad:";
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(184, 164);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.PasswordChar = '.';
            this.txtSifreTekrar.Size = new System.Drawing.Size(246, 27);
            this.txtSifreTekrar.TabIndex = 32;
            // 
            // lblSifreTekrar
            // 
            this.lblSifreTekrar.BackColor = System.Drawing.Color.Silver;
            this.lblSifreTekrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSifreTekrar.Location = new System.Drawing.Point(101, 164);
            this.lblSifreTekrar.Name = "lblSifreTekrar";
            this.lblSifreTekrar.Size = new System.Drawing.Size(77, 34);
            this.lblSifreTekrar.TabIndex = 33;
            this.lblSifreTekrar.Text = "Şifre :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 363);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.lblSifreTekrar);
            this.Controls.Add(this.btnKayıtOlustur);
            this.Controls.Add(this.rdbKadin);
            this.Controls.Add(this.rdbErkek);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnKayıtOlustur;
        private RadioButton rdbKadin;
        private RadioButton rdbErkek;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private TextBox txtAd;
        private Label lblCinsiyet;
        private Label lblSifre;
        private Label lblKullaniciAdi;
        private Label lblAd;
        private TextBox txtSifreTekrar;
        private Label lblSifreTekrar;
    }
}