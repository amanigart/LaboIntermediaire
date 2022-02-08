using AdoToolbox;
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
    public class ListeFilmsViewModel : ViewModelBase
    {
        public ListeFilmsViewModel()
        {
            _listeFilms = new ObservableCollection<DetailFilm>(_db.GetMovieDetailList());
        }

        DBservices _db = new DBservices();

        private int _idfilm;
        private string _titre;
        private int _idgenre;
        private string _genre;
        private int _idRealisateur;
        private string _realisateur;
        private int _idScenariste;
        private string _scenariste;
        private int _datesortie;
        private string _duree;
        private string _synopsis;
        private ObservableCollection<DetailFilm> _listeFilms;

        //private DetailFilmViewModel _selectedItem;

        //public DetailFilmViewModel SelectedItem
        //{
        //    get { return _selectedItem; }
        //    set
        //    {
        //        _selectedItem = value;
        //        RaisePropertyChanged(nameof(SelectedItem));
        //        SelectedItem.ShowDetailMovie();
        //    }
        //}

        public ObservableCollection<DetailFilm> ListeFilms
        {
            get { return _listeFilms; }
            set { _listeFilms = value; }
        }

        public int IdFilm
        {
            get { return _idfilm; }
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
            get { return _idgenre; }
            set
            {
                if (_idgenre != value)
                {
                    _idgenre = value;
                    RaisePropertyChanged(nameof(IdGenre));
                }
            }
        }

        public string Genre
        {
            get { return _genre; }
            set
            {
                if (_genre != value)
                {
                    _genre = value;
                    RaisePropertyChanged(nameof(Genre));
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

        public string Realisateur
        {
            get { return _realisateur; }
            set
            {
                if (_realisateur != value)
                {
                    _realisateur = value;
                    RaisePropertyChanged(nameof(Realisateur));
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

        public string Scenariste
        {
            get { return _scenariste; }
            set
            {
                if (_scenariste != value)
                {
                    _scenariste = value;
                    RaisePropertyChanged(nameof(Scenariste));
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

        public int DateSortie
        {
            get { return _datesortie; }
            set
            {
                if (_datesortie != value)
                {
                    _datesortie = value;
                    RaisePropertyChanged(nameof(DateSortie));
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

    }
}
