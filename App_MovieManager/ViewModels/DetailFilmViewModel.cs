using App_MovieManager.Models;
using App_MovieManager.Tools;
using App_MovieManager.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MovieManager.ViewModels
{
    public class DetailFilmViewModel : ViewModelBase
    {
        //public DetailFilmViewModel(DetailFilm film)
        //{
        //    _currentMovie = film;
        //}

        private DetailFilm _currentMovie;
        private DBservices _db = new DBservices();

        //private int _idFilm;
        //private string _titre;
        //private int _idGenre;
        //private string _nomGenre;
        //private string _duree;
        //private int _idRealisateur;
        //private string _nomRealisateur;
        //private int _idScenariste;
        //private string _nomScenariste;
        //private string _synopsis;
        //private int _dateSortie;
        private CommandBase _showMovieDetailCommand;
        private ObservableCollection<CastingDetail> _casting;

        public int IdFilm
        {
            get { return _currentMovie.IdFilm; }
            set { }
        }

        public string Titre
        {
            get { return _currentMovie.Titre; }
        }

        //public int IdGenre
        //{

        //}

        public string NomGenre
        {
            get { return _currentMovie.Genre; }
        }

        public string Duree
        {
            get { return _currentMovie.Duree; }
        }

        //public int IdRealisateur
        //{

        //}

        public string NomRealisateur
        {
            get { return _currentMovie.Realisateur; }
        }

        //public int IdScenariste
        //{

        //}

        public string NomScenariste
        {
            get { return _currentMovie.Scenariste; }
        }

        public string Synopsis
        {
            get { return _currentMovie.Synopsis; }
        }

        public int DateSortie
        {
            get { return _currentMovie.AnneeSortie; }
        }

        public CommandBase ShowMovieDetailCommand
        {
            get { return _showMovieDetailCommand ?? (_showMovieDetailCommand = new CommandBase(ShowMovieDetail )); }
        }

        public void ShowMovieDetail()
        {
            DetailsFilmWindow dw = new DetailsFilmWindow();
            dw.DataContext = this;
            dw.Show();
        }

    }
}
