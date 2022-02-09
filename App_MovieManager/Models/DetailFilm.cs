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
        public int IdGenre { get; set; }
        public string Genre { get; set; }
        public int IdRealisateur { get; set; }
        public string NomRealisateur { get; set; }
        public string PrenomRealisateur { get; set; }
        public DateTime DateNaissRealisateur { get; set; }
        public string NationaliteRealisateur { get; set; }
        public int IdScenariste { get; set; }
        public string NomScenariste { get; set; }
        public string PrenomScenariste { get; set; }
        public DateTime DateNaissScenariste { get; set; }
        public string NationaliteScenariste { get; set; }
        public string Synopsis { get; set; }
        public int AnneeSortie { get; set; }
        public string Duree { get; set; }
        //public Dictionary<string, string> Casting { get; set; }

        public Dictionary<int, string> ListeRealisateurs { get; set; }

        public static DetailFilm Converter(SqlDataReader reader)
        {
            return new DetailFilm
            {
                IdFilm = (int)reader["Id_Film"],
                Titre = (string)reader["Titre"],
                IdGenre = (int)reader["Id_Genre"],
                Genre = (string)reader["GenreDeFilm"],
                IdRealisateur = (int)reader["idRealisateur"],
                NomRealisateur = (string)reader["nomRealisateur"],
                PrenomRealisateur= (string)reader["prenomRealisateur"],
                DateNaissRealisateur = (DateTime)reader["datenaissRealisateur"],
                NationaliteRealisateur = (String)reader["nationaliteRealisateur"],
                IdScenariste = (int)reader["idScenariste"],
                NomScenariste = (string)reader["nomScenariste"],
                PrenomScenariste= (String)reader["prenomScenariste"],
                DateNaissScenariste=(DateTime)reader["datenaissScenariste"],
                NationaliteScenariste=(String)reader["nationaliteScenariste"],
                Synopsis = (string)reader["Synopsis"],
                AnneeSortie = (int)reader["DateSortie"],
                Duree = (string)reader["Duree"]
            };
        }
    }
}
