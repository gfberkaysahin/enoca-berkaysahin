using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityFilm
    {
        private string id;
        private string name;
        private string genre;
        private string director;
        private string year;
        private string cinemaNameID;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Director { get => director; set => director = value; }
        public string Year { get => year; set => year = value; }
        public string CinemaNameID { get => cinemaNameID; set => cinemaNameID = value; }
    }
}
