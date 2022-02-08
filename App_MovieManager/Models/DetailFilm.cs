using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MovieManager.Models
{
    public class DetailFilm
    {
        public int IdFilm { get; set; }
        public string Titre { get; set; }
        public string Genre { get; set; }
        public string Realisateur { get; set; }
        public string Scenariste { get; set; }
        public string Synopsis { get; set; }
        public int AnneeSortie { get; set; }
        public string Duree { get; set; }
        public Dictionary<string, string> Casting { get; set; }

        public static DetailFilm Converter(SqlDataReader reader)
        {
            return new DetailFilm
            {
                IdFilm = (int)reader["Id_Film"],
                Titre = (string)reader["Titre"],
                Genre = (string)reader["GenreDeFilm"],
                Realisateur = (string)reader["Realisateur"],
                Scenariste = (string)reader["Scenariste"],
                Synopsis = (string)reader["Synopsis"],
                AnneeSortie = (int)reader["DateSortie"],
                Duree = (string)reader["Duree"]
            };
        }
    }
}
