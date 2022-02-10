using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MovieManager.Models
{
    public class Collection
    {
        public int IdFilm { get; set; }
        public int IdUser { get; set; }
        public int Rating { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsInTrash { get; set; }
        public string TitreFilm { get; set; }

        public static Collection Converter(SqlDataReader reader)
        {
            return new Collection()
            {
                IdFilm = (int)reader["Id_Film"],
                IdUser = (int)reader["Id_User"]
            };
        }
    }
}
