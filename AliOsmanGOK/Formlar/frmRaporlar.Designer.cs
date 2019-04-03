namespace AliOsmanGOK.Formlar
{
    partial class frmRaporlar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKategoriListesi = new System.Windows.Forms.DataGridView();
            this.satisID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(589, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Toplam Kazanç : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.satisID,
            this.urunAdi,
            this.fiyat,
            this.satisTarihi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKategoriListesi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKategoriListesi.Location = new System.Drawing.Point(12, 12);
            this.dgvKategoriListesi.MultiSelect = false;
            this.dgvKategoriListesi.Name = "dgvKategoriListesi";
            this.dgvKategoriListesi.ReadOnly = true;
            this.dgvKategoriListesi.RowHeadersVisible = false;
            this.dgvKategoriListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKategoriListesi.ShowCellErrors = false;
            this.dgvKategoriListesi.ShowCellToolTips = false;
            this.dgvKategoriListesi.ShowEditingIcon = false;
            this.dgvKategoriListesi.ShowRowErrors = false;
            this.dgvKategoriListesi.Size = new System.Drawing.Size(760, 505);
            this.dgvKategoriListesi.TabIndex = 6;
            // 
            // satisID
            // 
            this.satisID.DataPropertyName = "satisID";
            this.satisID.HeaderText = "#";
            this.satisID.Name = "satisID";
            this.satisID.ReadOnly = true;
            // 
            // urunAdi
            // 
            this.urunAdi.DataPropertyName = "esyaAdi";
            this.urunAdi.HeaderText = "Ürün Adı";
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.ReadOnly = true;
            this.urunAdi.Width = 250;
            // 
            // fiyat
            // 
            this.fiyat.DataPropertyName = "fiyat";
            this.fiyat.HeaderText = "Fiyat";
            this.fiyat.Name = "fiyat";
            this.fiyat.ReadOnly = true;
            this.fiyat.Width = 160;
            // 
            // satisTarihi
            // 
            this.satisTarihi.DataPropertyName = "satisTarihi";
            this.satisTarihi.HeaderText = "Satış Tarihi";
            this.satisTarihi.Name = "satisTarihi";
            this.satisTarihi.ReadOnly = true;
            this.satisTarihi.Width = 240;
            // 
            // frmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvKategoriListesi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmRaporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.frmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKategoriListesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisID;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisTarihi;
    }
}