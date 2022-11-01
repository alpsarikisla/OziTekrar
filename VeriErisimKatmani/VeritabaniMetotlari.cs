using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriErisimKatmani
{
    public class VeritabaniMetotlari
    {
        SqlConnection baglanti; SqlCommand komut;

        public VeritabaniMetotlari()
        {
            baglanti = new SqlConnection(VeritabaniYollari.OziDbYol);
            komut = baglanti.CreateCommand();
        }

        #region Şehir Metotları

        public List<Sehir> SehirleriGetir()
        {
            try
            {
                List<Sehir> sehirler = new List<Sehir>();
                komut.CommandText = "SELECT * FROM Sehirler";
                baglanti.Open();
                SqlDataReader reader = komut.ExecuteReader();

                while (reader.Read())
                {
                    Sehir sehir = new Sehir();
                    sehir.ID = reader.GetInt32(0);
                    sehir.Isim = reader.GetString(1);
                    sehirler.Add(sehir);
                }
                return sehirler;
            }
            finally
            {
                baglanti.Close();
            }

        }

        #endregion

        #region Personel Metotları

        public bool PersonelEkle(string isim, string soyisim, string telefon, string adres, int SehirID)
        {
            try
            {
                komut.CommandText = "INSERT INTO Personeller(Isim, Soyisim, Telefon, Adres, Sehir_ID) VALUES(@Isim, @Soyisim, @Telefon, @Adres, @Sehir_ID)";
                komut.Parameters.AddWithValue("@Isim", isim);
                komut.Parameters.AddWithValue("@Soyisim", soyisim);
                komut.Parameters.AddWithValue("@Telefon", telefon);
                komut.Parameters.AddWithValue("@Adres", adres);
                komut.Parameters.AddWithValue("@Sehir_ID", SehirID);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        #endregion

    }
}
