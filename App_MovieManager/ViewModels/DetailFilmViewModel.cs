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
        public DetailFilmViewModel()
        {
            _film = _db.GetMovieDetail(1);
        }

        private FilmDetail _film = new FilmDetail();
        private DBservices _db = new DBservices();

        private int _idFilm;
        private string _titre;
        private int _idGenre;
        private string _nomGenre;
        private string _duree;
        private int _idRealisateur;
        private string _nomRealisateur;
        private int _idScenariste;
        private string _nomScenariste;
        private string _synopsis;
        private int _dateSortie;
        private CommandBase _detailFilmCommand;
        private ObservableCollection<CastingDetail> _casting;

        public int IdFilm
        {
            get { return _idFilm; }
            set
            {
                if (_idFilm != value)
                {
                    _idFilm = value;
                    RaisePropertyChanged(nameof(IdFilm));
                }
            }
        }

        public string Titre
        {
            get { return _titre; }
            set
            {
                if (_titre != value)
                {
                    _titre = value;
                    RaisePropertyChanged(nameof(Titre));
                }
            }
        }

        public int IdGenre
        {
            get { return _idGenre; }
            set
            {
                if (_idGenre != value)
                {
                    _idGenre = value;
                    RaisePropertyChanged(nameof(IdGenre));
                }
            }
        }

        public string NomGenre
        {
            get { return _nomGenre; }
            set
            {
                if (_nomGenre != value)
                {
                    _nomGenre = value;
                    RaisePropertyChanged(nameof(NomGenre));
                }
            }
        }

        public string Duree
        {
            get { return _duree; }
            set
            {
                if (_duree != value)
                {
                    _duree = value;
                    RaisePropertyChanged(nameof(Duree));
                }
            }
        }

        public int IdRealisateur
        {
            get { return _idRealisateur; }
            set
            {
                if (_idRealisateur != value)
                {
                    _idRealisateur = value;
                    RaisePropertyChanged(nameof(IdRealisateur));
                }
            }
        }

        public string NomRealisateur
        {
            get { return _nomRealisateur; }
            set
            {
                if (_nomRealisateur != value)
                {
                    _nomRealisateur = value;
                    RaisePropertyChanged(nameof(NomRealisateur));
                }
            }
        }

        public int IdScenariste
        {
            get { return _idScenariste; }
            set
            {
                if (_idScenariste != value)
                {
                    _idScenariste = value;
                    RaisePropertyChanged(nameof(IdScenariste));
                }
            }
        }

        public string NomScenariste
        {
            get { return _nomScenariste; }
            set
            {
                if (_nomScenariste != value)
                {
                    _nomScenariste = value;
                    RaisePropertyChanged(nameof(NomScenariste));
                }
            }
        }

        public string Synopsis
        {
            get { return _synopsis; }
            set
            {
                if (_synopsis != value)
                {
                    _synopsis = value;
                    RaisePropertyChanged(nameof(Synopsis));
                }
            }
        }

        public int DateSortie
        {
            get { return _dateSortie; }
            set
            {
                if (_dateSortie != value)
                {
                    _dateSortie = value;
                    RaisePropertyChanged(nameof(DateSortie));
                }
            }
        }

        public CommandBase DetailFilmCommand
        {
            get { return _detailFilmCommand ?? (_detailFilmCommand = new CommandBase(ShowDetailMovie)); }
        }

        public void ShowDetailMovie()
        {
            DetailsFilmWindow dw = new DetailsFilmWindow();
            dw.DataContext = this;
            dw.Show();
        }
    }
}
