namespace AliOsmanGOK
{
    partial class frmAnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaForm));
            this.tTarihSaat = new System.Windows.Forms.Timer(this.components);
            this.lblTarihSaat = new System.Windows.Forms.Label();
            this.lblVeriTabaniBaglantisi = new System.Windows.Forms.Label();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnMobilya = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tTarihSaat
            // 
            this.tTarihSaat.Enabled = true;
            this.tTarihSaat.Interval = 50;
            this.tTarihSaat.Tick += new System.EventHandler(this.tTarihSaat_Tick);
            // 
            // lblTarihSaat
            // 
            this.lblTarihSaat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarihSaat.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblTarihSaat.Location = new System.Drawing.Point(553, 529);
            this.lblTarihSaat.Name = "lblTarihSaat";
            this.lblTarihSaat.Size = new System.Drawing.Size(203, 23);
            this.lblTarihSaat.TabIndex = 1;
            this.lblTarihSaat.Text = "Tarih Saat";
            this.lblTarihSaat.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblVeriTabaniBaglantisi
            // 
            this.lblVeriTabaniBaglantisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVeriTabaniBaglantisi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeriTabaniBaglantisi.Location = new System.Drawing.Point(9, 529);
            this.lblVeriTabaniBaglantisi.Name = "lblVeriTabaniBaglantisi";
            this.lblVeriTabaniBaglantisi.Size = new System.Drawing.Size(219, 23);
            this.lblVeriTabaniBaglantisi.TabIndex = 1;
            this.lblVeriTabaniBaglantisi.Text = "Veri tabanı bağlantısı başarılı.";
            this.lblVeriTabaniBaglantisi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btnSatisYap.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSatisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisYap.Font = new System.Drawing.Font("Saira", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisYap.Image = global::AliOsmanGOK.Properties.Resources.satis;
            this.btnSatisYap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatisYap.Location = new System.Drawing.Point(12, 12);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(744, 168);
            this.btnSatisYap.TabIndex = 0;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatisYap.UseVisualStyleBackColor = false;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnKategoriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriler.Font = new System.Drawing.Font("Saira", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriler.Image = global::AliOsmanGOK.Properties.Resources.kategoriler;
            this.btnKategoriler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKategoriler.Location = new System.Drawing.Point(512, 196);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(244, 126);
            this.btnKategoriler.TabIndex = 0;
            this.btnKategoriler.Text = "Kategoriler";
            this.btnKategoriler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKategoriler.UseVisualStyleBackColor = true;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRaporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporlar.Font = new System.Drawing.Font("Saira", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlar.Image = global::AliOsmanGOK.Properties.Resources.raporlar;
            this.btnRaporlar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRaporlar.Location = new System.Drawing.Point(12, 328);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(744, 126);
            this.btnRaporlar.TabIndex = 0;
            this.btnRaporlar.Text = "Raporlar";
            this.btnRaporlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRaporlar.UseVisualStyleBackColor = true;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // btnMobilya
            // 
            this.btnMobilya.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnMobilya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMobilya.Font = new System.Drawing.Font("Saira", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMobilya.Image = ((System.Drawing.Image)(resources.GetObject("btnMobilya.Image")));
            this.btnMobilya.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMobilya.Location = new System.Drawing.Point(12, 196);
            this.btnMobilya.Name = "btnMobilya";
            this.btnMobilya.Size = new System.Drawing.Size(244, 126);
            this.btnMobilya.TabIndex = 0;
            this.btnMobilya.Text = "Mobilya Bölümü";
            this.btnMobilya.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMobilya.UseVisualStyleBackColor = true;
            this.btnMobilya.Click += new System.EventHandler(this.btnMobilya_Click);
            // 
            // frmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 561);
            this.Controls.Add(this.lblVeriTabaniBaglantisi);
            this.Controls.Add(this.lblTarihSaat);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.btnKategoriler);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnMobilya);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(784, 600);
            this.MinimumSize = new System.Drawing.Size(784, 600);
            this.Name = "frmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobilya Satış Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAnaForm_FormClosed);
            this.Load += new System.EventHandler(this.frmAnaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMobilya;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.Timer tTarihSaat;
        private System.Windows.Forms.Label lblTarihSaat;
        private System.Windows.Forms.Label lblVeriTabaniBaglantisi;
        private System.Windows.Forms.Button btnRaporlar;
    }
}

