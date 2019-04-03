namespace AliOsmanGOK.Formlar
{
    partial class frmSatisYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisYap));
            this.flpUrunler = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.lvSepet = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.esyaAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.esyaFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsSepetSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsiUrunSil = new System.Windows.Forms.ToolStripMenuItem();
            this.xlblSepet = new System.Windows.Forms.Label();
            this.cmsSepetSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpUrunler
            // 
            this.flpUrunler.Location = new System.Drawing.Point(372, 12);
            this.flpUrunler.Margin = new System.Windows.Forms.Padding(0);
            this.flpUrunler.Name = "flpUrunler";
            this.flpUrunler.Size = new System.Drawing.Size(500, 540);
            this.flpUrunler.TabIndex = 0;
            // 
            // lblTutar
            // 
            this.lblTutar.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(12, 12);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(354, 100);
            this.lblTutar.TabIndex = 1;
            this.lblTutar.Text = "Tutar : ";
            this.lblTutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSatisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisYap.Font = new System.Drawing.Font("Saira", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisYap.Location = new System.Drawing.Point(12, 452);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(354, 97);
            this.btnSatisYap.TabIndex = 2;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // lvSepet
            // 
            this.lvSepet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.esyaAdi,
            this.esyaFiyati});
            this.lvSepet.ContextMenuStrip = this.cmsSepetSil;
            this.lvSepet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvSepet.FullRowSelect = true;
            this.lvSepet.Location = new System.Drawing.Point(12, 163);
            this.lvSepet.MultiSelect = false;
            this.lvSepet.Name = "lvSepet";
            this.lvSepet.Size = new System.Drawing.Size(354, 283);
            this.lvSepet.TabIndex = 3;
            this.lvSepet.UseCompatibleStateImageBehavior = false;
            this.lvSepet.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "#";
            this.id.Width = 50;
            // 
            // esyaAdi
            // 
            this.esyaAdi.Text = "Ürün Adı";
            this.esyaAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.esyaAdi.Width = 180;
            // 
            // esyaFiyati
            // 
            this.esyaFiyati.Text = "Ürün Fiyatı";
            this.esyaFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.esyaFiyati.Width = 103;
            // 
            // cmsSepetSil
            // 
            this.cmsSepetSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsiUrunSil});
            this.cmsSepetSil.Name = "cmsSepetSil";
            this.cmsSepetSil.Size = new System.Drawing.Size(158, 34);
            // 
            // cmsiUrunSil
            // 
            this.cmsiUrunSil.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmsiUrunSil.Image = global::AliOsmanGOK.Properties.Resources.sil;
            this.cmsiUrunSil.Name = "cmsiUrunSil";
            this.cmsiUrunSil.Size = new System.Drawing.Size(157, 30);
            this.cmsiUrunSil.Text = "Ürünü Sil";
            this.cmsiUrunSil.Click += new System.EventHandler(this.cmsiUrunSil_Click);
            // 
            // xlblSepet
            // 
            this.xlblSepet.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xlblSepet.Location = new System.Drawing.Point(12, 112);
            this.xlblSepet.Name = "xlblSepet";
            this.xlblSepet.Size = new System.Drawing.Size(354, 48);
            this.xlblSepet.TabIndex = 4;
            this.xlblSepet.Text = "Sepet";
            this.xlblSepet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSatisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.xlblSepet);
            this.Controls.Add(this.lvSepet);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.flpUrunler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmSatisYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Ekranı";
            this.Load += new System.EventHandler(this.frmSatisYap_Load);
            this.cmsSepetSil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpUrunler;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.ListView lvSepet;
        private System.Windows.Forms.Label xlblSepet;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader esyaAdi;
        private System.Windows.Forms.ColumnHeader esyaFiyati;
        private System.Windows.Forms.ContextMenuStrip cmsSepetSil;
        private System.Windows.Forms.ToolStripMenuItem cmsiUrunSil;
    }
}