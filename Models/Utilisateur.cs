using System.Data.SqlClient;

namespace Models
{
    public class Utilisateur
    {
        public int IdUser { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public string Passwd { get; set; }

        public static Utilisateur Converter(SqlDataReader reader)
        {
            return new Utilisateur
            {
                IdUser = (int)reader["Id_User"],
                Email = (string)reader["Email"],
                Nickname = (string)reader["Nickname"]
            };
        }
    }
}