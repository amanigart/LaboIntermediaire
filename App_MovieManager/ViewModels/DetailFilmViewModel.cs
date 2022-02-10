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
        public DetailFilmViewModel(DetailFilm film)
        {
            _currentMovie = film;
            MessageValidationModify = "TEST";
            ListeRealisateurs = new ObservableCollection<Personne>(_db.GetDirectorsList());
            ListeScenaristes = new ObservableCollection<Personne>(_db.GetWriterList());
            User = Session.CurrentUser;
        }

        private DetailFilm _currentMovie;
        private DBservices _db = new DBservices();

        private string _messageValidationModify;
        public string MessageErreur { get; set; }
        public string MessageValidationModify
        {
            get => _messageValidationModify;
            set
            {
                if (_messageValidationModify != value)
                {
                    _messageValidationModify = value;
                    RaisePropertyChanged(nameof(MessageValidationModify));
                }
            }
        }

        // Session User
        public Utilisateur User { get; set; }


        // Liste Realisateurs
        private ObservableCollection<Personne> _listeRealisateurs;
        public ObservableCollection<Personne> ListeRealisateurs
        {
            get { return _listeRealisateurs; }
            set { _listeRealisateurs = value; }
        }
        private string _selectedDirector;
        public string SelectedDirector
        {
            get => _selectedDirector;
            set
            {
                _selectedDirector = value;
                RaisePropertyChanged(nameof(SelectedDirector));
            }
        }

        // Liste Scenaristes
        private ObservableCollection<Personne> _listeScenaristes;
        public ObservableCollection<Personne> ListeScenaristes
        {
            get { return _listeScenaristes; }
            set { _listeScenaristes = value; }
        }
        private string _selectedWriter;
        public string SelectedWriter
        {
            get => _selectedWriter;
            set
            {
                _selectedWriter = value;
                RaisePropertyChanged(nameof(SelectedWriter));
            }
        }

        // Propriétés du film courant
        public int IdFilm
        {
            get { return _currentMovie.IdFilm; }
        }

        public string Titre
        {
            get { return _currentMovie.Titre; }
            set
            {
                if (_currentMovie.Titre != value)
                {
                    _currentMovie.Titre = value;
                    RaisePropertyChanged(nameof(Titre));
                }
            }
        }

        public int IdGenre
        {
            get => _currentMovie.IdGenre;
            set
            {
                if (_currentMovie.IdGenre != value)
                {
                    _currentMovie.IdGenre = value;
                    RaisePropertyChanged(nameof(IdGenre));
                }
            }
        }

        public string NomGenre
        {
            get { return _currentMovie.Genre; }
            set
            {
                if (_currentMovie.Genre != value)
                {
                    _currentMovie.Genre = value;
                    RaisePropertyChanged(nameof(NomGenre));
                }
            }
        }

        public string Duree
        {
            get { return _currentMovie.Duree; }
            set
            {
                if (_currentMovie.Duree != value)
                {
                    _currentMovie.Duree = value;
                    RaisePropertyChanged(nameof(Duree));
                }
            }
        }

        public int IdRealisateur
        {
            get => _currentMovie.IdRealisateur;
            set
            {
                if (_currentMovie.IdRealisateur != value)
                {
                    _currentMovie.IdRealisateur = value;
                    RaisePropertyChanged(nameof(IdRealisateur));
                }
            }
        }

        public string Realisateur
        {
            get => $"{_currentMovie.PrenomRealisateur} {_currentMovie.NomRealisateur}";
        }

        public string NomRealisateur
        {
            get { return _currentMovie.NomRealisateur; }
            set
            {
                if (_currentMovie.NomRealisateur != value)
                {
                    _currentMovie.NomRealisateur = value;
                    RaisePropertyChanged(nameof(NomRealisateur));
                }
            }
        }

        public string PrenomRealisateur
        {
            get { return _currentMovie.PrenomRealisateur; }
            set
            {
                if (_currentMovie.PrenomRealisateur != value)
                {
                    _currentMovie.PrenomRealisateur = value;
                    RaisePropertyChanged(nameof(PrenomRealisateur));
                }
            }
        }

        public DateTime DateNaissanceRealisateur
        {
            get => _currentMovie.DateNaissRealisateur;
            set
            {
                if (_currentMovie.DateNaissRealisateur != value)
                {
                    _currentMovie.DateNaissRealisateur = value;
                    RaisePropertyChanged(nameof(DateNaissanceRealisateur));
                }
            }
        }

        public string NationaliteRealisateur
        {
            get => _currentMovie.NationaliteRealisateur;
            set
            {
                if (_currentMovie.NationaliteRealisateur != value)
                {
                    _currentMovie.NationaliteRealisateur = value;
                    RaisePropertyChanged(nameof(NationaliteRealisateur));
                }
            }
        }

        public int IdScenariste
        {
            get => _currentMovie.IdScenariste;
            set
            {
                if (_currentMovie.IdScenariste != value)
                {
                    _currentMovie.IdScenariste = value;
                    RaisePropertyChanged(nameof(IdScenariste));
                }
            }
        }

        public string Scenariste
        {
            get => $"{_currentMovie.PrenomScenariste} {_currentMovie.NomScenariste}";
        }

        public string NomScenariste
        {
            get { return _currentMovie.NomScenariste; }
            set
            {
                if (_currentMovie.NomScenariste != value)
                {
                    _currentMovie.NomScenariste = value;
                    RaisePropertyChanged(nameof(NomScenariste));
                }
            }
        }

        public string PrenomScenariste
        {
            get => _currentMovie.PrenomScenariste;
            set
            {
                if (_currentMovie.PrenomScenariste != value)
                {
                    _currentMovie.PrenomScenariste = value;
                    RaisePropertyChanged(nameof(PrenomScenariste));
                }
            }
        }

        public DateTime DateNaissanceScenariste
        {
            get => _currentMovie.DateNaissScenariste;
            set
            {
                if (_currentMovie.DateNaissScenariste != value)
                {
                    _currentMovie.DateNaissScenariste = value;
                    RaisePropertyChanged(nameof(DateNaissanceScenariste));
                }
            }
        }

        public string NationaliteScenariste
        {
            get => _currentMovie.NationaliteScenariste;
            set
            {
                if (_currentMovie.NationaliteScenariste != value)
                {
                    _currentMovie.NationaliteScenariste = value;
                    RaisePropertyChanged(nameof(NationaliteScenariste));
                }
            }
        }

        public string Synopsis
        {
            get { return _currentMovie.Synopsis; }
            set
            {
                if (_currentMovie.Synopsis != value)
                {
                    _currentMovie.Synopsis = value;
                    RaisePropertyChanged(nameof(Synopsis));
                }
            }
        }

        public int DateSortie
        {
            get { return _currentMovie.AnneeSortie; }
            set
            {
                if (_currentMovie.AnneeSortie != value)
                {
                    _currentMovie.AnneeSortie = value;
                    RaisePropertyChanged(nameof(DateSortie));
                }
            }
        }

        public string Affiche
        {
            get { return _currentMovie.Affiche; }
            set
            {
                if (_currentMovie.Affiche != value)
                {
                    _currentMovie.Affiche = value;
                    RaisePropertyChanged(nameof(Affiche));
                }
            }
        }


        // Commande vers Detail Film
        private CommandBase _showMovieDetailCommand;
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


        // Commande vers Modifier Film
        private CommandBase _showMovieModifyCommand;
        public CommandBase ShowMovieModifyCommand
        {
            get { return _showMovieModifyCommand ?? (_showMovieModifyCommand = new CommandBase(ShowMovieModify)); }
        }
        public void ShowMovieModify()
        {
            ModifyWindow mw = new ModifyWindow();
            mw.DataContext = this;
            mw.Show();
        }

        // Commande Enregistrer Update Film
        private CommandBase _saveMovieModifyCommand;
        public CommandBase SaveMovieModifyCommand
        {
            get { return _saveMovieModifyCommand ?? (_saveMovieModifyCommand = new CommandBase(SaveMovieModify)); }
        }

        public void SaveMovieModify()
        {
            int rowsGenre = _db.UpdateGenreTable(NomGenre, IdGenre);
            int rowsReal = _db.UpdatePersonneTable(IdRealisateur, NomRealisateur, PrenomRealisateur, NationaliteRealisateur, DateNaissanceRealisateur);
            int rowsScen = _db.UpdatePersonneTable(IdScenariste, NomScenariste, PrenomScenariste, NationaliteRealisateur, DateNaissanceScenariste);
            int rowsFilm = _db.UpdateFilmTable(IdFilm, IdRealisateur, IdScenariste, Titre, Synopsis, Duree, DateSortie);

            MessageValidationModify = "Le film a bien été mis à jour";
        }

        // Commande Add Favori
        private CommandBase _addFavCommand;
        public CommandBase AddFavCommand
        {
            get { return _addFavCommand ?? (_addFavCommand = new CommandBase(AddFavori)); }
        }
        public void AddFavori()
        {
            int rows = _db.AddMovieToCollection(IdFilm, User.IdUser);
        }

    }
}
