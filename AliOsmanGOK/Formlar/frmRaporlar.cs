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
    public partial class frmRaporlar : Form
    {
        SQLiteConnection baglanti = new SQLiteConnection(CS.veriTabaniBilgileri.baglanti);

        public frmRaporlar()
        {
            InitializeComponent();
        }

        private void frmRaporlar_Load(object sender, EventArgs e)
        {
            toplamKazanc();
            satilanUrunler();
        }
        void toplamKazanc()
        {
            baglanti.Open();
            SQLiteCommand toplamKazanc = new SQLiteCommand("SELECT SUM(fiyat) FROM satislar_items", baglanti);
            label1.Text = "Toplam Kazanç : " + toplamKazanc.ExecuteScalar().ToString() + " ₺";
            baglanti.Close();
        }
        void satilanUrunler()
        {
            baglanti.Open();
            DataSet ds = new DataSet();
            var da = new SQLiteDataAdapter("SELECT * FROM satislarview", baglanti);
            da.Fill(ds);
            dgvKategoriListesi.DataSource = ds.Tables[0].DefaultView;
            baglanti.Close();
        }
    }
}
