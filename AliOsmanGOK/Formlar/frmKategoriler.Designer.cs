namespace AliOsmanGOK.Formlar
{
    partial class frmKategoriler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xgbKategoriBolumu = new System.Windows.Forms.GroupBox();
            this.btnKategoriKaydet = new System.Windows.Forms.Button();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.xlblUrunAdi = new System.Windows.Forms.Label();
            this.xgbKategoriler = new System.Windows.Forms.GroupBox();
            this.dgvKategoriListesi = new System.Windows.Forms.DataGridView();
            this.cmsKategori = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiKategoriDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKategoriSil = new System.Windows.Forms.ToolStripMenuItem();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xgbKategoriBolumu.SuspendLayout();
            this.xgbKategoriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriListesi)).BeginInit();
            this.cmsKategori.SuspendLayout();
            this.SuspendLayout();
            // 
            // xgbKategoriBolumu
            // 
            this.xgbKategoriBolumu.Controls.Add(this.btnKategoriKaydet);
            this.xgbKategoriBolumu.Controls.Add(this.txtKategoriAdi);
            this.xgbKategoriBolumu.Controls.Add(this.xlblUrunAdi);
            this.xgbKategoriBolumu.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.xgbKategoriBolumu.Location = new System.Drawing.Point(12, 12);
            this.xgbKategoriBolumu.Name = "xgbKategoriBolumu";
            this.xgbKategoriBolumu.Size = new System.Drawing.Size(360, 144);
            this.xgbKategoriBolumu.TabIndex = 0;
            this.xgbKategoriBolumu.TabStop = false;
            this.xgbKategoriBolumu.Text = "Kategori Bölümü";
            // 
            // btnKategoriKaydet
            // 
            this.btnKategoriKaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKategoriKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriKaydet.Location = new System.Drawing.Point(166, 85);
            this.btnKategoriKaydet.Name = "btnKategoriKaydet";
            this.btnKategoriKaydet.Size = new System.Drawing.Size(166, 37);
            this.btnKategoriKaydet.TabIndex = 7;
            this.btnKategoriKaydet.Text = "Kategori Kaydet";
            this.btnKategoriKaydet.UseVisualStyleBackColor = true;
            this.btnKategoriKaydet.Click += new System.EventHandler(this.btnKategoriKaydet_Click);
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.BackColor = System.Drawing.Color.White;
            this.txtKategoriAdi.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategoriAdi.Location = new System.Drawing.Point(148, 51);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(184, 28);
            this.txtKategoriAdi.TabIndex = 6;
            // 
            // xlblUrunAdi
            // 
            this.xlblUrunAdi.AutoSize = true;
            this.xlblUrunAdi.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xlblUrunAdi.Location = new System.Drawing.Point(38, 54);
            this.xlblUrunAdi.Name = "xlblUrunAdi";
            this.xlblUrunAdi.Size = new System.Drawing.Size(104, 21);
            this.xlblUrunAdi.TabIndex = 5;
            this.xlblUrunAdi.Text = "Kategori Adı : ";
            // 
            // xgbKategoriler
            // 
            this.xgbKategoriler.Controls.Add(this.dgvKategoriListesi);
            this.xgbKategoriler.Font = new System.Drawing.Font("Open Sans", 11F);
            this.xgbKategoriler.Location = new System.Drawing.Point(12, 162);
            this.xgbKategoriler.Name = "xgbKategoriler";
            this.xgbKategoriler.Size = new System.Drawing.Size(360, 165);
            this.xgbKategoriler.TabIndex = 1;
            this.xgbKategoriler.TabStop = false;
            this.xgbKategoriler.Text = "Kategori Listesi";
            // 
            // dgvKategoriListesi
            // 
            this.dgvKategoriListesi.AllowUserToAddRows = false;
            this.dgvKategoriListesi.AllowUserToDeleteRows = false;
            this.dgvKategoriListesi.AllowUserToResizeColumns = false;
            this.dgvKategoriListesi.AllowUserToResizeRows = false;
            this.dgvKategoriListesi.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKategoriListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKategoriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategoriListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.kategoriAdi});
            this.dgvKategoriListesi.ContextMenuStrip = this.cmsKategori;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKategoriListesi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKategoriListesi.Location = new System.Drawing.Point(6, 32);
            this.dgvKategoriListesi.MultiSelect = false;
            this.dgvKategoriListesi.Name = "dgvKategoriListesi";
            this.dgvKategoriListesi.ReadOnly = true;
            this.dgvKategoriListesi.RowHeadersVisible = false;
            this.dgvKategoriListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKategoriListesi.ShowCellErrors = false;
            this.dgvKategoriListesi.ShowCellToolTips = false;
            this.dgvKategoriListesi.ShowEditingIcon = false;
            this.dgvKategoriListesi.ShowRowErrors = false;
            this.dgvKategoriListesi.Size = new System.Drawing.Size(348, 127);
            this.dgvKategoriListesi.TabIndex = 1;
            this.dgvKategoriListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKategoriListesi_CellContentClick);
            // 
            // cmsKategori
            // 
            this.cmsKategori.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmsKategori.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKategoriDuzenle,
            this.tsmiKategoriSil});
            this.cmsKategori.Name = "cmsMobilya";
            this.cmsKategori.Size = new System.Drawing.Size(199, 56);
            // 
            // tsmiKategoriDuzenle
            // 
            this.tsmiKategoriDuzenle.Image = global::AliOsmanGOK.Properties.Resources.duzenle;
            this.tsmiKategoriDuzenle.Name = "tsmiKategoriDuzenle";
            this.tsmiKategoriDuzenle.Size = new System.Drawing.Size(198, 26);
            this.tsmiKategoriDuzenle.Text = "Kategori Düzenle";
            this.tsmiKategoriDuzenle.Click += new System.EventHandler(this.tsmiKategoriDuzenle_Click);
            // 
            // tsmiKategoriSil
            // 
            this.tsmiKategoriSil.Image = global::AliOsmanGOK.Properties.Resources.sil;
            this.tsmiKategoriSil.Name = "tsmiKategoriSil";
            this.tsmiKategoriSil.Size = new System.Drawing.Size(198, 26);
            this.tsmiKategoriSil.Text = "Kategori Sil";
            this.tsmiKategoriSil.Click += new System.EventHandler(this.tsmiKategoriSil_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // kategoriAdi
            // 
            this.kategoriAdi.DataPropertyName = "kategoriAdi";
            this.kategoriAdi.HeaderText = "Kategori Adı";
            this.kategoriAdi.Name = "kategoriAdi";
            this.kategoriAdi.ReadOnly = true;
            this.kategoriAdi.Width = 287;
            // 
            // frmKategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 336);
            this.Controls.Add(this.xgbKategoriler);
            this.Controls.Add(this.xgbKategoriBolumu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 375);
            this.MinimumSize = new System.Drawing.Size(400, 375);
            this.Name = "frmKategoriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Yönetimi";
            this.Load += new System.EventHandler(this.frmKategoriler_Load);
            this.xgbKategoriBolumu.ResumeLayout(false);
            this.xgbKategoriBolumu.PerformLayout();
            this.xgbKategoriler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriListesi)).EndInit();
            this.cmsKategori.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox xgbKategoriBolumu;
        private System.Windows.Forms.GroupBox xgbKategoriler;
        private System.Windows.Forms.DataGridView dgvKategoriListesi;
        private System.Windows.Forms.Button btnKategoriKaydet;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Label xlblUrunAdi;
        private System.Windows.Forms.ContextMenuStrip cmsKategori;
        private System.Windows.Forms.ToolStripMenuItem tsmiKategoriDuzenle;
        private System.Windows.Forms.ToolStripMenuItem tsmiKategoriSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriAdi;
    }
}