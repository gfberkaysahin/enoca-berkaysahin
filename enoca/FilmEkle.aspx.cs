using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace enoca
{
    public partial class FilmEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityFilm ent = new EntityFilm();
            ent.Name = TxtName.Text;
            ent.Genre= TxtGenre.Text;
            ent.Director = TxtDirector.Text;
            ent.Year = TxtYear.Text;
            ent.CinemaNameID = TxtCinema.Text;
            BLLFilm.FilmEkleBLL(ent);
            Response.Redirect("FilmListesi.Aspx");
        }
    }
}