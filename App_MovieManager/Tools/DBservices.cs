using AdoToolbox;
using App_MovieManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MovieManager.Tools
{
    public class DBservices
    {
        // ADRIEN : "Data Source=5233;Initial Catalog=MovieDB;User ID=adrien;Password=Test1234;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        // ERIC : "Data Source=5210;Initial Catalog=MovieDB;User ID=sa;Password=Test1234;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private string _connectionString = "Data Source=5233;Initial Catalog=MovieDB;User ID=adrien;Password=Test1234;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public bool CheckUserExist(string email,string passwd)
        {
            Connection cnx = new Connection(_connectionString);
            string sql = "UserLogin";
            Command cmd = new Command(sql, true);
            cmd.AddParameter("email", email);
            cmd.AddParameter("password", passwd);
            Utilisateur u = cnx.ExecuteReader(cmd, Utilisateur.Converter).FirstOrDefault();

            if (u is null)
                return false;

            Session.CurrentUser = new Utilisateur()
            {
                IdUser = u.IdUser,
                Nickname = u.Nickname,
                Email = u.Email
            };

            return true;
        }

        public IEnumerable<Personne> GetListActors()
        {
            Connection cnx = new Connection(_connectionString);
            string sql = "SELECT Id_Personne, Nom, Prenom FROM Personne"; // todo: retourne liste personnes => jointure : acteurs
            Command cmd = new Command(sql);

            return cnx.ExecuteReader(cmd, Personne.Converter);
        }

        public IEnumerable<Film> GetMovieList()
        {
            Connection cnx = new Connection(_connectionString);
            string sql = "SELECT Id_Film, Titre, Realisateur, DateSortie FROM Film";
            Command cmd = new Command(sql);

            return cnx.ExecuteReader(cmd, Film.Converter);
        }
    }
}
