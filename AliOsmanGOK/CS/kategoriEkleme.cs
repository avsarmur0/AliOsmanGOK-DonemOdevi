using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliOsmanGOK.CS
{
    class kategoriEkleme
    {
        public static SQLiteConnection baglanti = new SQLiteConnection(CS.veriTabaniBilgileri.baglantiS);
        public static bool kategoriEkle(string kategoriAdi)
        {
            if (baglanti.State != System.Data.ConnectionState.Open) baglanti.Open();
            SQLiteCommand kategoriEkle = new SQLiteCommand("INSERT INTO kategoriler(kategoriAdi) VALUES('" + kategoriAdi + "')", baglanti);
            return kategoriEkle.ExecuteNonQuery() == 1 ? true : false;
        }
        public static bool kategoriGuncelle(string kategoriAdi, int kID)
        {
            if (baglanti.State != System.Data.ConnectionState.Open) baglanti.Open();
            SQLiteCommand kategoriGuncelle = new SQLiteCommand("UPDATE kategoriler SET kategoriAdi='" + kategoriAdi + "' WHERE id=" + kID, baglanti);
            return kategoriGuncelle.ExecuteNonQuery() == 1 ? true : false;
        }
    }
}
