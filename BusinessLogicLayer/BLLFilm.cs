using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLFilm
    {
        public static int FilmEkleBLL(EntityFilm p)
        {
            if (p.Name != null && p.Genre != null && p.Director != null && p.Year != null && p.CinemaNameID != null && p.Name != "" && p.Genre != "" && p.Director != "" && p.Year !="" && p.CinemaNameID !="")
            {
                return DALFilm.FilmEkle(p);
            }
            return -1;
        }

        public static List<EntityFilm> BllListele()
        {
            return DALFilm.FilmListesi();
        }

        public static bool FilmSilBLL(int p)
        {
            if (p >=0)
            {
                return DALFilm.FilmSil(p);
            }
            return false;
        }

        public static List<EntityFilm> BllDetay(int p)
        {
            return DALFilm.FilmDetay(p);
        }

        public static bool FilmGuncelleBLL(EntityFilm p)
        {
            if (p.Name != null && p.Genre != null && p.Director != null && p.Year != null && p.CinemaNameID != null && p.Name != "" && p.Genre != "" && p.Director != "" && p.Year != "" && p.CinemaNameID != "")
            {
                return DALFilm.FilmGuncelle(p);

            }
            return false;
        }
    }
}
