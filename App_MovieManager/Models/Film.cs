using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MovieManager.Models
{
    public class Film
    {
        public int IdFilm { get; set; }
        public string Titre { get; set; }
        public int IdGenre { get; set; }
        public int Realisateur { get; set; }
        public int Scenariste { get; set; }
        public string Synopsis { get; set; }
        public int DateSortie { get; set; }
        public string AnneeSortie { get; set; }
        public string Duree { get; set; }
        public byte[] Affiche { get; set; }

        public static Film Converter(SqlDataReader reader)
        {
            return new Film
            {
                IdFilm = (int)reader["Id_Film"],
                Titre = (string)reader["Titre"],
                Realisateur = (int)reader["Realisateur"],
                DateSortie = (int)reader["DateSortie"]
            };
        }
    }
}
