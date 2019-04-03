using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliOsmanGOK.Formlar
{
    public partial class frmMobilya : Form
    {
        SQLiteConnection baglanti = new SQLiteConnection(CS.veriTabaniBilgileri.baglantiS);
        void baglantiAc()
        {
            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }
        }
        public frmMobilya()
        {
            InitializeComponent();
        }

        private void txtUrunFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void frmMobilyaEkle_Load(object sender, EventArgs e)
        {
            urunKategorisiCek();
            urunRenkleriCek();
            urunListesiniCek();
            if (cmbUrunKategorisi.Items.Count > 0) { cmbUrunKategorisi.SelectedIndex = 0; } else { cmbUrunKategorisi.Items.Add("99"); cmbUrunKategorisi.SelectedIndex = 0; }
            if (cmbUrunRengi.Items.Count > 0) { cmbUrunRengi.SelectedIndex = 0; } else { cmbUrunRengi.Items.Add("99 | Renk Yok"); cmbUrunRengi.SelectedIndex = 0; }
        }
        void urunKategorisiCek()
        {
            baglantiAc();
            SQLiteCommand kategori = new SQLiteCommand("SELECT * FROM kategoriler", baglanti);
            SQLiteDataReader kategoriOku = kategori.ExecuteReader();
            if (kategoriOku.HasRows)
            {
                while (kategoriOku.Read())
                {
                    if (kategoriOku["id"].ToString().Length == 1)
                    {
                        cmbUrunKategorisi.Items.Add("0" + kategoriOku["id"].ToString() + " | " + kategoriOku["kategoriAdi"].ToString());
                    }
                }
            }
            baglanti.Close();
        }
        void urunRenkleriCek()
        {
            baglantiAc();
            SQLiteCommand renk = new SQLiteCommand("SELECT * FROM renkler", baglanti);
            SQLiteDataReader renkOku = renk.ExecuteReader();
            if (renkOku.HasRows)
            {
                while (renkOku.Read())
                {
                    if (renkOku["id"].ToString().Length == 1)
                    {
                        cmbUrunRengi.Items.Add("0" + renkOku["id"].ToString() + " | " + renkOku["renkAdi"].ToString());
                    }
                }
            }
            baglanti.Close();
        }
        void urunListesiniCek()
        {
            baglantiAc();
            DataSet ds = new DataSet();
            var da = new SQLiteDataAdapter("SELECT * FROM esyalarsch", baglanti);
            da.Fill(ds);
            dgvUrunListesi.DataSource = ds.Tables[0].DefaultView;
            baglanti.Close();
        }

        private void btnUrunuKaydet_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text != string.Empty && (txtUrunFiyati.Text != string.Empty || txtUrunFiyati.Text != ","))
            {
                if (duzenle == 1)
                {
                    if (CS.urunEkleme.urunGuncelle(txtUrunAdi.Text, txtUrunAciklama.Text, double.Parse(txtUrunFiyati.Text), int.Parse(cmbUrunKategorisi.Text.Substring(0, 2)), int.Parse(cmbUrunRengi.Text.Substring(0, 2)), uID) == true)
                    {
                        MessageBox.Show("Ürün güncelleme başarılı.");
                        urunListesiniCek();
                        duzenle = 0;
                        txtUrunAciklama.Text = txtUrunAdi.Text = txtUrunFiyati.Text = string.Empty;
                        cmbUrunKategorisi.SelectedIndex = cmbUrunRengi.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Bir hata var.");
                    }
                    baglanti.Close();
                }
                else
                {
                    if (CS.urunEkleme.urunEkle(txtUrunAdi.Text, txtUrunAciklama.Text, double.Parse(txtUrunFiyati.Text), int.Parse(cmbUrunKategorisi.Text.Substring(0, 2)), int.Parse(cmbUrunRengi.Text.Substring(0, 2))) == true)
                    {
                        MessageBox.Show("Ürün ekleme başarılı.");
                        urunListesiniCek();
                        txtUrunAciklama.Text = txtUrunAdi.Text = txtUrunFiyati.Text = string.Empty;
                        cmbUrunKategorisi.SelectedIndex = cmbUrunRengi.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Bir hata var.");
                    }
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz." + "\n" + "Ürün Adı ve Ürün Fiyatı");
            }
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (rbUrunAdi.Checked == true)
            {
                baglantiAc();
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter("SELECT * FROM esyalarsch WHERE esyaAdi LIKE '%" + txtAranacakKelime.Text + "%'", baglanti);
                da.Fill(ds);
                dgvUrunListesi.DataSource = ds.Tables[0].DefaultView;
                baglanti.Close();
            }
            else
            {
                baglantiAc();
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter("SELECT * FROM esyalarsch WHERE kategoriAdi LIKE '%" + txtAranacakKelime.Text + "%'", baglanti);
                da.Fill(ds);
                dgvUrunListesi.DataSource = ds.Tables[0].DefaultView;
                baglanti.Close();
            }
        }

        private void tsmiUrunuSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunListesi.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Ürünü silmek istediğinize emin misiniz?", "Ürün Siliniyor!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    baglantiAc();
                    SQLiteCommand urunSil = new SQLiteCommand("DELETE FROM esyalar WHERE id=" + dgvUrunListesi.SelectedRows[0].Cells[0].Value.ToString(), baglanti);
                    if (urunSil.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Silme başarılı.");
                        urunListesiniCek();
                    }
                    else
                    {
                        MessageBox.Show("Test");
                    }
                }
            }
        }
        int duzenle = 0, uID = 0;

        private void txtAranacakKelime_TextChanged(object sender, EventArgs e)
        {
            if (txtAranacakKelime.Text.Length == 0)
            {
                urunListesiniCek();
            }
        }

        private void tsmiUrunuDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvUrunListesi.SelectedRows.Count > 0)
            {
                uID = int.Parse(dgvUrunListesi.SelectedRows[0].Cells[0].Value.ToString());
                duzenle = 1;
                txtUrunAciklama.Text = dgvUrunListesi.SelectedRows[0].Cells[5].Value.ToString();
                txtUrunAdi.Text = dgvUrunListesi.SelectedRows[0].Cells[1].Value.ToString();
                txtUrunFiyati.Text = dgvUrunListesi.SelectedRows[0].Cells[2].Value.ToString();


                cmbUrunKategorisi.SelectedValue = "";
                cmbUrunRengi.SelectedValue = "";
            }
        }
    }
}
