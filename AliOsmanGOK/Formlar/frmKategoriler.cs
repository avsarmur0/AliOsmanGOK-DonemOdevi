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
    public partial class frmKategoriler : Form
    {
        public frmKategoriler()
        {
            InitializeComponent();
        }
        int duzenle = 0, kID;
        SQLiteConnection baglanti = new SQLiteConnection(CS.veriTabaniBilgileri.baglantiS);
        void baglantiAc()
        {
            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }
        }
        private void tsmiKategoriDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvKategoriListesi.SelectedRows.Count > 0)
            {
                kID = int.Parse(dgvKategoriListesi.SelectedRows[0].Cells[0].Value.ToString());
                duzenle = 1;
                txtKategoriAdi.Text = dgvKategoriListesi.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void tsmiKategoriSil_Click(object sender, EventArgs e)
        {
            if (dgvKategoriListesi.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Kategoriyi silmek istediğinize emin misiniz?", "Ürün Siliniyor!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    baglantiAc();
                    SQLiteCommand kategoriSil = new SQLiteCommand("DELETE FROM kategoriler WHERE id=" + int.Parse(dgvKategoriListesi.SelectedRows[0].Cells[0].Value.ToString()), baglanti);
                    if (kategoriSil.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Silme başarılı.");
                        kategoriListesiCek();
                    }
                    else
                    {
                        MessageBox.Show("Hata.");
                    }
                }
            }
        }

        private void btnKategoriKaydet_Click(object sender, EventArgs e)
        {
            if (txtKategoriAdi.Text != string.Empty)
            {
                if (duzenle == 0)
                {
                    if (CS.kategoriEkleme.kategoriEkle(txtKategoriAdi.Text) == true)
                    {
                        MessageBox.Show("Kategori ekleme başarılı");
                        txtKategoriAdi.Text = string.Empty;
                        duzenle = 0;
                        kategoriListesiCek();
                    }
                }
                else
                {
                    if (dgvKategoriListesi.SelectedRows.Count > 0)
                    {
                        if (CS.kategoriEkleme.kategoriGuncelle(txtKategoriAdi.Text, kID) == true)
                        {
                            MessageBox.Show("Kategori güncelleme başarılı");
                            duzenle = 0;
                            txtKategoriAdi.Text = string.Empty;
                            kategoriListesiCek();
                        }
                    }
                }
            }
        }

        private void frmKategoriler_Load(object sender, EventArgs e)
        {
            kategoriListesiCek();
        }

        private void dgvKategoriListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void kategoriListesiCek()
        {
            baglantiAc();
            DataSet ds = new DataSet();
            var da = new SQLiteDataAdapter("SELECT * FROM kategoriler", baglanti);
            da.Fill(ds);
            dgvKategoriListesi.DataSource = ds.Tables[0].DefaultView;
            baglanti.Close();
        }
    }
}
