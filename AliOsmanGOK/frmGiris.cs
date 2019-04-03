using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AliOsmanGOK
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        public void gizle()
        {
            this.Hide();
        }
        public void goster()
        {
            this.Show();
        }
        SQLiteConnection baglanti = new SQLiteConnection(CS.veriTabaniBilgileri.baglantiS);
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SQLiteCommand listele = new SQLiteCommand("SELECT * FROM kullanicilar WHERE kullaniciAdi='" + txtKullaniciAdi.Text + "' AND sifre='" + txtSifre.Text + "'", baglanti);
            SQLiteDataReader listeleOku = listele.ExecuteReader();
            if (listeleOku.HasRows)
            {
                frmAnaForm anaForm = new frmAnaForm();
                this.Hide();
                txtKullaniciAdi.Text = txtSifre.Text = "";
                anaForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.");
            }
            baglanti.Close();
        }
    }
}
