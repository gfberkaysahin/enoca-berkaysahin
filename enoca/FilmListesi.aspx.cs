using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace enoca
{
    public partial class FilmListesi2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Getir();

        }

        public void Getir()
        {

            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = baglansatir();
            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("SELECT K.ID,K.Name,K.Genre,K.Director,K.Year,Y.SName FROM Tbl_FilmTablosu K INNER JOIN Tbl_SinemaTablosu Y ON Y.CinemaID = K.CinemaNameID", conn);
            try
            {

                conn.Open();
                reader = comm.ExecuteReader();

                rp1.DataSource = reader;
                rp1.DataBind();

                reader.Close();
            }
            catch
            {

                Response.Write("Veri okuma işleminde hata meydana geldi!");
            }
            finally
            {

                conn.Close();
            }
        }
        public string baglansatir()
        {
            return "Data Source=.;Initial Catalog=DbEnoca;Integrated Security=True";
        }

    }
}