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
        }

        private DetailFilm _currentMovie;
        private DBservices _db = new DBservices();

        public string MessageErreur { get; set; }

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


        // Commande Detail Film
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


        // Commande vers page modifier film
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

        // Commande Enregistrer update film
        private CommandBase _saveMovieModifyCommand;
        public CommandBase SaveMovieModifyCommand
        {
            get { return _saveMovieModifyCommand ?? (_saveMovieModifyCommand = new CommandBase(SaveMovieModify)); }
        }

        public void SaveMovieModify()
        {
            DBservices _db = new DBservices();
            
            int rows = _db.UpdateMovieTable(Titre);
            //if (rows > 0)
            //    MessageErreur = "La table Film a bient été mise à jour.";
            //else
            //    MessageErreur = "Erreur, la table Film n'a pas été mise à jour";


        }

    }
}
