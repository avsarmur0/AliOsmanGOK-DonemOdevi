using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace AliOsmanGOK
{
    public partial class frmAnaForm : Form
    {
        public frmAnaForm()
        {
            InitializeComponent();
            CS.veriTabaniBilgileri.baglantiAc();
        }

        private void tTarihSaat_Tick(object sender, EventArgs e)
        {
            lblTarihSaat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void frmAnaForm_Load(object sender, EventArgs e)
        {
            if (CS.evrenselDegiskenler.veriBaglantisi == true) lblVeriTabaniBaglantisi.Text = "Veri tabanı bağlantısı başarılı."; else lblVeriTabaniBaglantisi.Text = "Veri tabanı bağlantısı başarısız.";
        }

        private void btnMobilya_Click(object sender, EventArgs e)
        {
            Formlar.frmMobilya MobilyaEkle = new Formlar.frmMobilya();
            MobilyaEkle.ShowDialog();
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            Formlar.frmKategoriler Kategoriler = new Formlar.frmKategoriler();
            Kategoriler.ShowDialog();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            Formlar.frmRaporlar Raporlar = new Formlar.frmRaporlar();
            Raporlar.ShowDialog();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            Formlar.frmSatisYap satisYap = new Formlar.frmSatisYap();
            satisYap.ShowDialog();
        }

        private void frmAnaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //frmGiris goster = (frmGiris)Application.OpenForms["frmGiris"];
            //goster.goster();
        }
    }
}
