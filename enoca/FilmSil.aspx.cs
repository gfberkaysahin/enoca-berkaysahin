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
    public partial class FilmSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            Response.Write(x);
            EntityFilm ent = new EntityFilm();
            ent.Id = x.ToString();
            BLLFilm.FilmSilBLL(x);
            Response.Redirect("FilmListesi.Aspx");

        }
    }
}