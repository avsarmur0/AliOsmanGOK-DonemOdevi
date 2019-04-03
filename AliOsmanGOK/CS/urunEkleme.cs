using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliOsmanGOK.CS
{
    class urunEkleme
    {
        public static SQLiteConnection baglanti = new SQLiteConnection(CS.veriTabaniBilgileri.baglantiS);
        public static bool urunEkle(string urunadi, string aciklama, double fiyat, int kategori, int renk)
        {
            if (baglanti.State != System.Data.ConnectionState.Open) baglanti.Open();
            SQLiteCommand urunEkle = new SQLiteCommand("INSERT INTO esyalar(esyaAdi,esyaAciklama,esyaFiyati,esyaKategorisi,esyaRengi) VALUES('" + urunadi + "','" + aciklama + "',@fiyat," + kategori + "," + renk + ")", baglanti);
            urunEkle.Parameters.Add(new SQLiteParameter("@fiyat", fiyat));
            return urunEkle.ExecuteNonQuery() == 1 ? true : false;
        }
        public static bool urunGuncelle(string urunadi, string aciklama, double fiyat, int kategori, int renk, int id)
        {
            if (baglanti.State != System.Data.ConnectionState.Open) baglanti.Open();
            SQLiteCommand urunGuncelle = new SQLiteCommand("UPDATE esyalar SET esyaAdi='" + urunadi + "',esyaAciklama='" + aciklama + "',esyaFiyati=@fiyat,esyaKategorisi=" + kategori + ",esyaRengi=" + renk + " WHERE id=" + id, baglanti);
            urunGuncelle.Parameters.Add(new SQLiteParameter("@fiyat", fiyat));
            return urunGuncelle.ExecuteNonQuery() == 1 ? true : false;
        }
    }
}
