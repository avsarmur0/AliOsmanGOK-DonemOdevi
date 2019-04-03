namespace AliOsmanGOK
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.gbKullaniciGirisi = new System.Windows.Forms.GroupBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.pbKullanici = new System.Windows.Forms.PictureBox();
            this.pbSifre = new System.Windows.Forms.PictureBox();
            this.gbKullaniciGirisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSifre)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKullaniciGirisi
            // 
            this.gbKullaniciGirisi.Controls.Add(this.pbSifre);
            this.gbKullaniciGirisi.Controls.Add(this.pbKullanici);
            this.gbKullaniciGirisi.Controls.Add(this.btnGirisYap);
            this.gbKullaniciGirisi.Controls.Add(this.txtSifre);
            this.gbKullaniciGirisi.Controls.Add(this.txtKullaniciAdi);
            this.gbKullaniciGirisi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbKullaniciGirisi.ForeColor = System.Drawing.Color.White;
            this.gbKullaniciGirisi.Location = new System.Drawing.Point(201, 99);
            this.gbKullaniciGirisi.Name = "gbKullaniciGirisi";
            this.gbKullaniciGirisi.Size = new System.Drawing.Size(362, 246);
            this.gbKullaniciGirisi.TabIndex = 0;
            this.gbKullaniciGirisi.TabStop = false;
            this.gbKullaniciGirisi.Text = "Giriş";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(96, 83);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(187, 27);
            this.txtKullaniciAdi.TabIndex = 0;
            this.txtKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(96, 116);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(187, 27);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.ForeColor = System.Drawing.Color.Black;
            this.btnGirisYap.Location = new System.Drawing.Point(190, 149);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(93, 32);
            this.btnGirisYap.TabIndex = 2;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // pbKullanici
            // 
            this.pbKullanici.BackColor = System.Drawing.Color.White;
            this.pbKullanici.Image = global::AliOsmanGOK.Properties.Resources.kullanici;
            this.pbKullanici.Location = new System.Drawing.Point(98, 84);
            this.pbKullanici.Name = "pbKullanici";
            this.pbKullanici.Size = new System.Drawing.Size(25, 25);
            this.pbKullanici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKullanici.TabIndex = 2;
            this.pbKullanici.TabStop = false;
            // 
            // pbSifre
            // 
            this.pbSifre.BackColor = System.Drawing.Color.White;
            this.pbSifre.Image = global::AliOsmanGOK.Properties.Resources.sifre;
            this.pbSifre.Location = new System.Drawing.Point(98, 117);
            this.pbSifre.Name = "pbSifre";
            this.pbSifre.Size = new System.Drawing.Size(25, 25);
            this.pbSifre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSifre.TabIndex = 2;
            this.pbSifre.TabStop = false;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(765, 445);
            this.Controls.Add(this.gbKullaniciGirisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiris";
            this.gbKullaniciGirisi.ResumeLayout(false);
            this.gbKullaniciGirisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSifre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKullaniciGirisi;
        private System.Windows.Forms.PictureBox pbKullanici;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.PictureBox pbSifre;
    }
}