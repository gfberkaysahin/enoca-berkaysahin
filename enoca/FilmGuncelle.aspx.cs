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
    public partial class FilmGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            TxtId.Text = x.ToString();
            TxtId.Enabled = false;

            if (Page.IsPostBack == false)
            {
                List<EntityFilm> FilmList = BLLFilm.BllDetay(x);
                TxtName.Text = FilmList[0].Name.ToString();
                TxtGenre.Text = FilmList[0].Genre.ToString();
                TxtDirector.Text = FilmList[0].Director.ToString();
                TxtYear.Text = FilmList[0].Year.ToString();
                TxtCinema.Text = FilmList[0].CinemaNameID.ToString();
            }
            
        }

        protected void TxtGenre_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityFilm ent = new EntityFilm();
            ent.Name = TxtName.Text;
            ent.Genre = TxtGenre.Text;
            ent.Director = TxtDirector.Text;
            ent.Year = TxtYear.Text;
            ent.Id = TxtId.Text;
            ent.CinemaNameID = TxtCinema.Text;
            BLLFilm.FilmGuncelleBLL(ent);
            Response.Redirect("FilmListesi.aspx");

        }
    }
}