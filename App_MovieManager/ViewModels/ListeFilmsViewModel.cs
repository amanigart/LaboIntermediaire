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
            _listeFilms = new ObservableCollection<FilmDetail>(_db.GetMovieList());
        }

        DBservices _db = new DBservices();

        private int _idfilm;
        private string _titre;
        private int _idgenre;
        private int _realisateur;
        private int _datesortie;
        private string _duree;
        private ObservableCollection<FilmDetail> _listeFilms;
        private DetailFilmViewModel _selectedItem;

        public DetailFilmViewModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                RaisePropertyChanged(nameof(SelectedItem));
                SelectedItem.ShowDetailMovie();
            }
        }

        public ObservableCollection<FilmDetail> ListeFilms
        {
            get { return _listeFilms; }
            set { _listeFilms = value; }
        }

        public int IdFilm
        {
            get { return _idfilm; }
            set
            {
                if (_idfilm != value)
                {
                    _idfilm = value;
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

        public int Realisateur
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

    }
}
