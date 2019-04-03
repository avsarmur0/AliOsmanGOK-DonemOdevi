using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace AliOsmanGOK.CS
{
    class veriTabaniBilgileri
    {
        public static string baglantiS = "Data Source=" + Application.StartupPath + "\\mobilya.db;Version=3;Synchronous=Full;Pooling=True;FailIfMissing=True";
        public static SQLiteConnection baglanti = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\mobilya.db;Version=3;Synchronous=Full;Pooling=True;FailIfMissing=True");
        public static void baglantiAc()
        {
            SQLiteConnection baglanti = new SQLiteConnection(baglantiS);
            if (baglanti.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    baglanti.Open();
                    CS.evrenselDegiskenler.veriBaglantisi = true;
                }
                catch (SQLiteException)
                {
                    CS.evrenselDegiskenler.veriBaglantisi = false;
                }
            }
        }
    }
}
