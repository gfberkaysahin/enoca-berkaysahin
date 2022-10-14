using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALFilm
    {
        public static int FilmEkle(EntityFilm parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into Tbl_FilmTablosu(Name,Genre,Director,Year,CinemaNameID) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.Name);
            komut1.Parameters.AddWithValue("@p2", parametre.Genre);
            komut1.Parameters.AddWithValue("@p3", parametre.Director);
            komut1.Parameters.AddWithValue("@p4", parametre.Year);
            komut1.Parameters.AddWithValue("@p5", parametre.CinemaNameID);
            return komut1.ExecuteNonQuery(); //Eklenilen kayıt sayısını bana döndür.
        }
        

        public static List<EntityFilm> FilmListesi()
        {
            
            List<EntityFilm> degerler = new List<EntityFilm>();
            SqlCommand komut2 = new SqlCommand("SELECT K.ID,K.Name,K.Genre,K.Director,K.Year, K.CinemaNameID FROM  Tbl_FilmTablosu K INNER JOIN Tbl_SinemaTablosu Y ON Y.CinemaID = K.CinemaNameID", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                
                EntityFilm ent = new EntityFilm();
                ent.Id = dr["ID"].ToString();
                ent.Name = dr["Name"].ToString();
                ent.Genre = dr["Genre"].ToString();
                ent.Director = dr["Director"].ToString();
                ent.Year = dr["Year"].ToString();
                ent.CinemaNameID = dr["CinemaNameID"].ToString();
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }

        public static bool FilmSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("Delete From Tbl_FilmTablosu where ID=@P1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", parametre);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static List<EntityFilm> FilmDetay(int id)
        {
            List<EntityFilm> degerler = new List<EntityFilm>();
            SqlCommand komut4 = new SqlCommand("Select * from Tbl_FilmTablosu Where ID=@P1", Baglanti.bgl);
            komut4.Parameters.AddWithValue("@P1", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityFilm ent = new EntityFilm();
                ent.Name = dr["Name"].ToString();
                ent.Genre = dr["Genre"].ToString();
                ent.Director = dr["Director"].ToString();
                ent.Year = dr["Year"].ToString();
                ent.CinemaNameID = dr["CinemaNameID"].ToString();
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }

        public static bool FilmGuncelle(EntityFilm deger)
        {
            SqlCommand komut5 = new SqlCommand("Update Tbl_FilmTablosu Set Name=@P1,Genre=@P2,Director=@P3,Year=@P4,CinemaNameID=@P5 WHERE ID=@P6", Baglanti.bgl);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@P1", deger.Name);
            komut5.Parameters.AddWithValue("@P2", deger.Genre);
            komut5.Parameters.AddWithValue("@P3", deger.Director);
            komut5.Parameters.AddWithValue("@P4", deger.Year);
            komut5.Parameters.AddWithValue("@P5", deger.CinemaNameID);
            komut5.Parameters.AddWithValue("@P6", deger.Id);
            return komut5.ExecuteNonQuery() > 0;
        }

    }
}

