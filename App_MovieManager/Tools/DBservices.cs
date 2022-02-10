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
        private string _connectionString = "Data Source=5233;Initial Catalog=DBLabo;User ID=adrien;Password=Test1234;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public bool CheckIfUserExist(string email,string passwd)
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

        public void CreateUser(string nom, string prenom, string email, string password, string nickname)
        {
            Connection cnx = new Connection(_connectionString);
            string sql = "UserRegister";
            Command cmd = new Command(sql, true);
            cmd.AddParameter("name", nom);
            cmd.AddParameter("firstName", prenom);
            cmd.AddParameter("email", email);
            cmd.AddParameter("password", password);
            cmd.AddParameter("nickname", nickname);
            int Rows = cnx.ExecuteNonQuery(cmd);

        }

        public IEnumerable<Personne> GetListActors()
        {
            Connection cnx = new Connection(_connectionString);
            string sql = "GetActorsList"; 
            Command cmd = new Command(sql, true);

            return cnx.ExecuteReader(cmd, Personne.Converter);
        }

        public IEnumerable<Personne> GetDirectorsList()
        {
            Connection cnx = new Connection(_connectionString);
            string sql = "SELECT p.Id_Personne, p.Nom, p.Prenom FROM Personne p JOIN Film f ON (p.Id_Personne = f.Realisateur)";
            Command cmd = new Command(sql);

            return cnx.ExecuteReader(cmd, Personne.Converter);
        }

        public IEnumerable<Personne> GetWriterList()
        {
            Connection cnx = new Connection(_connectionString);
            string sql = "SELECT p.Id_Personne, p.Nom, p.Prenom FROM Personne p JOIN Film f ON (p.Id_Personne = f.Scenariste)";
            Command cmd = new Command(sql);

            return cnx.ExecuteReader(cmd, Personne.Converter);
        }

        public IEnumerable<DetailFilm> GetMovieList()
        {
            Connection cnx = new Connection(_connectionString);
            string sql = "SELECT f.Id_Film, f.Titre, g.GenreDeFilm, CONCAT(r.Prenom,' ',r.Nom) AS Realisateur, CONCAT(s.Prenom,' ',s.Nom) AS Scenariste, f.DateSortie, f.Duree FROM Film f JOIN Genre g ON (f.Id_Genre = g.Id_Genre) JOIN Personne r ON (f.Realisateur = r.Id_Personne) JOIN Personne s ON (f.Scenariste = s.Id_Personne)";
            Command cmd = new Command(sql);

            return cnx.ExecuteReader(cmd, DetailFilm.Converter);
        }

        public DetailFilm GetMovieDetail(int idFilm)
        {
            Connection cnx = new Connection(_connectionString);
            string sql = "SELECT f.Id_Film, f.Titre, g.GenreDeFilm, CONCAT(r.Prenom, ' ', r.Nom) AS Realisateur, CONCAT(s.Prenom, ' ', s.Nom) AS Scenariste, f.Synopsis, f.DateSortie, f.Duree "
                       + "FROM Film f JOIN Genre g ON(f.Id_Genre = g.Id_Genre) JOIN Personne r ON(f.Realisateur = r.Id_Personne) JOIN Personne s ON(f.Scenariste = s.Id_Personne) "
                       + "WHERE f.Id_Film = @idFilm";
            Command cmd = new Command(sql);
            cmd.AddParameter("idFilm", idFilm);

            return cnx.ExecuteReader(cmd, DetailFilm.Converter).FirstOrDefault();                   
        }

        public IEnumerable<DetailFilm> GetMovieDetailList()
        {
            Connection cnx = new Connection(_connectionString);
            string sql = "GetMovieDetail";
            Command cmd = new Command(sql, true);

            return cnx.ExecuteReader(cmd, DetailFilm.Converter);
        }


        // UPDATE des tables
        public int UpdateGenreTable(string genre, int idGenre)
        {
            Connection cnx = new Connection(_connectionString);
            string sql = "UpdateGenre";
            Command cmd = new Command(sql, true);
            cmd.AddParameter("genre", genre);
            cmd.AddParameter("id", idGenre);

            return cnx.ExecuteNonQuery(cmd);
        }

        public int UpdatePersonneTable(int id, string nom, string prenom, string nationalite, DateTime dateNaissance)
        {
            Connection cnx = new Connection(_connectionString);
            string sql = "UpdatePersonne";
            Command cmd = new Command(sql, true);
            cmd.AddParameter("id", id);
            cmd.AddParameter("nom", nom);
            cmd.AddParameter("prenom", prenom);
            cmd.AddParameter("dateNaiss", dateNaissance);
            cmd.AddParameter("nationalite", nationalite);

            return cnx.ExecuteNonQuery(cmd);
        }

        public int UpdateFilmTable(int idFilm, int idRealisateur, int idScenariste, string titre, string synopsis, string duree, int dateSortie)
        {
            Connection cnx = new Connection(_connectionString);
            string sql = "UpdateFilm";
            Command cmd = new Command(sql, true);
            cmd.AddParameter("idFilm", idFilm);
            cmd.AddParameter("idRealisateur", idRealisateur);
            cmd.AddParameter("idScenariste", idScenariste);
            cmd.AddParameter("titre", titre);
            cmd.AddParameter("synopsis", synopsis);
            cmd.AddParameter("duree", duree);
            cmd.AddParameter("dateSortie", dateSortie);

            return cnx.ExecuteNonQuery(cmd);
        }

        // Collection
        public int AddMovieToCollection (int idFilm, int idUser)
        {
            Connection cnx = new Connection(_connectionString);
            string sql = "AddCollectionItem";
            Command cmd = new Command(sql, true);
            cmd.AddParameter("idFilm", idFilm);
            cmd.AddParameter("idUser", idUser);
            return cnx.ExecuteNonQuery(cmd);
        }

        public IEnumerable<ViewCollection> GetCollection(int idUser)
        {
            Connection cnx = new Connection(_connectionString);
            string sql = "DisplayCollection";
            Command cmd = new Command(sql, true);
            cmd.AddParameter("idUser", idUser);
            return cnx.ExecuteReader(cmd, ViewCollection.Converter);
        }

        public IEnumerable<DetailFilm> SearchMovielList(string query)
        {
            Connection cnx = new Connection(_connectionString);
            string sql = "SearchMovies";
            Command cmd = new Command(sql, true);
            cmd.AddParameter("query", query);

            return cnx.ExecuteReader(cmd, DetailFilm.Converter);
        }
    }
}
