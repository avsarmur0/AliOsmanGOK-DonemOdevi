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
    public partial class frmSatisYap : Form
    {
        public frmSatisYap()
        {
            InitializeComponent();
        }
        SQLiteConnection baglanti = new SQLiteConnection(CS.veriTabaniBilgileri.baglantiS);
        void baglantiAc()
        {
            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }
        }
        double toplam = 0; int toplamUrun = 0;
        private void frmSatisYap_Load(object sender, EventArgs e)
        {
            urunleriCek();
            lblTutar.Text = "Tutar : " + toplam.ToString();
        }

        void urunleriCek()
        {
            Font font = new Font("Times New Roman", 13.0f);
            baglantiAc();
            SQLiteCommand say = new SQLiteCommand("SELECT * FROM esyalar", baglanti);
            SQLiteDataReader sayOku = say.ExecuteReader();
            if (sayOku.HasRows)
            {
                while (sayOku.Read())
                {
                    Button btnUrun = new Button();
                    btnUrun.Size = new Size(flpUrunler.Width / 4, flpUrunler.Height / 6);
                    btnUrun.Name = sayOku["id"].ToString();
                    btnUrun.Text = sayOku["esyaAdi"].ToString();
                    btnUrun.Margin = new Padding(0, 0, 0, 0);
                    btnUrun.Font = font;
                    flpUrunler.Controls.Add(btnUrun);
                    btnUrun.Click += new EventHandler(BtnUrun_Click);
                }
            }
            baglanti.Close();
        }

        protected void BtnUrun_Click(object sender, EventArgs e)
        {
            Button btnUrun = sender as Button;
            baglantiAc();
            SQLiteCommand urunBilgi = new SQLiteCommand("SELECT * FROM esyalar WHERE id=" + int.Parse(btnUrun.Name), baglanti);
            SQLiteDataReader urunOku = urunBilgi.ExecuteReader();
            if (urunOku.HasRows)
            {
                if (urunOku.Read())
                {
                    lvSepet.Items.Add(new ListViewItem(new string[] { urunOku["id"].ToString(), urunOku["esyaAdi"].ToString(), urunOku["esyaFiyati"].ToString() }));
                    toplam += double.Parse(urunOku["esyaFiyati"].ToString());
                    lblTutar.Text = "Toplam Tutar : " + toplam.ToString();
                    toplamUrun = lvSepet.Items.Count;
                }
            }
        }

        private void cmsiUrunSil_Click(object sender, EventArgs e)
        {
            if (lvSepet.SelectedItems.Count > 0)
            {
                toplam -= double.Parse(lvSepet.SelectedItems[0].SubItems[2].Text);
                lvSepet.SelectedItems[0].Remove();
                lblTutar.Text = "Toplam Tutar : " + toplam.ToString();
                toplamUrun = lvSepet.Items.Count;
                if (lvSepet.Items.Count == 0)
                {
                    lblTutar.Text = "Toplam Tutar : 0";
                }
            }
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            try
            {
                int satisID = int.Parse(DateTime.Now.ToString("fffffff"));
                baglantiAc();
                SQLiteCommand satisEkle = new SQLiteCommand("INSERT INTO satislar(satisID,satisTarihi) VALUES(" + satisID + ",'" + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + "')", baglanti);
                if (satisEkle.ExecuteNonQuery() == 1)
                {
                    for (int i = 0; i < lvSepet.Items.Count; i++)
                    {
                        try
                        {
                            SQLiteCommand satisElemanEkle = new SQLiteCommand("INSERT INTO satislar_items(satisID,urunID,fiyat) VALUES(" + satisID + "," + lvSepet.Items[i].SubItems[0].Text + ",@fiyat)", baglanti);
                            satisElemanEkle.Parameters.Add(new SQLiteParameter("@fiyat", double.Parse(lvSepet.Items[i].SubItems[2].Text)));
                            satisElemanEkle.ExecuteNonQuery();
                            satisElemanEkle.Dispose();
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.ToString());
                        }
                    }
                }
                MessageBox.Show("Satış işlemi başarılı.");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Satış başarısız. Yolunda gitmeyen bir şeyler var.");
            }
        }
    }
}
