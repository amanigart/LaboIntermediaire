using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MovieManager.Models
{
    public class ViewCollection
    {
        public string Titre { get; set; }
        public string Realisateur { get; set; }
        public string Duree { get; set; }
        public int Rating { get; set; }

        public static ViewCollection Converter(SqlDataReader reader)
        {
            return new ViewCollection()
            {
                Titre = (string)reader["Titre"],
                Realisateur = (string)reader["Realisateur"],
                Duree = (string)reader["Duree"],
                Rating = (int)reader["Rating"]
            };
        }
    }
}
