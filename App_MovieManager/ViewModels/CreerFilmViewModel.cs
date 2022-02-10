using App_MovieManager.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MovieManager.ViewModels
{
    public class CreerFilmViewModel : ViewModelBase
    {

        // Ajouter un nouveau film via le formulaire 

        private int _idFilm;
        private string _titre;
        private int _idGenre;
        private string _nomGenre;
        private string _duree;
        private int _idRealisateur;
        private string _nomRealisateur;
        private string _prenomRealisateur;
        private string _nationaliteRealisateur;
        private DateTime _dobRealisateur;
        private int _idScenariste;
        private string _nomScenariste;
        private string _prenomScenariste;
        private string _nationaliteScenariste;
        private DateTime _dobScenariste;
        private string _synopsis;
        private int _dateSortie;
        private string _affiche;
        private CommandBase _detailFilmCommand;
        //private ObservableCollection<Casting...> _casting;

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
        public string PrenomRealisateur
        {
            get { return _prenomRealisateur; }
            set
            {
                if (_prenomRealisateur != value)
                {
                    _prenomRealisateur = value;
                    RaisePropertyChanged(nameof(PrenomRealisateur));
                }
            }
        }
        public string NationaliteRealisateur
        {
            get { return _nationaliteRealisateur; }
            set
            {
                if (_nationaliteRealisateur != value)
                {
                    _nationaliteRealisateur = value;
                    RaisePropertyChanged(nameof(NationaliteRealisateur));
                }
            }
        }
        public DateTime DateNaissanceRealisateur
        {
            get { return _dobRealisateur; }
            set
            {
                if (_dobRealisateur != value)
                {
                    _dobRealisateur = value;
                    RaisePropertyChanged(nameof(DateNaissanceRealisateur));
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

        public string PrenomScenariste
        {
            get { return _prenomScenariste; }
            set
            {
                if (_prenomScenariste != value)
                {
                    _prenomScenariste = value;
                    RaisePropertyChanged(nameof(PrenomScenariste));
                }
            }
        }

        public string NationaliteScenariste
        {
            get { return _nationaliteScenariste; }
            set
            {
                if (_nationaliteScenariste != value)
                {
                    _nationaliteScenariste = value;
                    RaisePropertyChanged(nameof(NationaliteScenariste));
                }
            }
        }

        public DateTime DateNaissanceScenariste
        {
            get { return _dobScenariste; }
            set
            {
                if (_dobScenariste != value)
                {
                    _dobScenariste = value;
                    RaisePropertyChanged(nameof(DateNaissanceScenariste));
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

        public string Affiche
        {
            get { return _affiche; }
            set
            {
                if (_affiche != value)
                {
                    _affiche = value;
                    RaisePropertyChanged(nameof(Affiche));
                }
            }
        }
        
    }
}
