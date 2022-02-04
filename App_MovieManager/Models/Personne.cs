using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MovieManager.Models
{
    public class Personne
    {
        public int IdPersonne { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Nationalite { get; set; }

        public static Personne Converter(SqlDataReader reader)
        {
            return new Personne
            {
                IdPersonne = (int)reader["Id_Personne"],
                Nom = (string)reader["Nom"],
                Prenom = (string)reader["Prenom"]
            };
        }
    }
}
