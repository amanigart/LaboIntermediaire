using AdoToolbox;
using App_MovieManager.Models;
using App_MovieManager.Tools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MovieManager.ViewModels
{
    public class ListeActeursViewModel : ViewModelBase
    {

        public ListeActeursViewModel()
        {
            _listeActeur = new ObservableCollection<Personne>(_db.GetListActors());
        }

        private DBservices _db = new DBservices();

        private int _idpersonne;
        private string _nom;
        private string _prenom;
        private DateTime _dob;
        private string _citizen;
        private ObservableCollection<Personne> _listeActeur;

        public ObservableCollection<Personne> ListeActeur
        {
            get { return _listeActeur; }
            set { _listeActeur = value; }
        }

        public int IdPersonne
        {
            get { return _idpersonne; }
            set
            {
                if (_idpersonne != value)
                {
                    _idpersonne = value;
                    RaisePropertyChanged(nameof(IdPersonne));
                }
            }
        }

        public string Nom
        {
            get { return _nom; }
            set
            {
                if (_nom != value)
                {
                    _nom = value;
                    RaisePropertyChanged(nameof(Nom));
                }
            }
        }

        public string Prenom
        {
            get { return _prenom; }
            set
            {
                if (_prenom != value)
                {
                    _prenom = value;
                    RaisePropertyChanged(nameof(Prenom));
                }
            }
        }

        public DateTime DateNaissance
        {
            get { return _dob; }
            set
            {
                if (_dob != value)
                {
                    _dob = value;
                    RaisePropertyChanged(nameof(DateNaissance));
                }
            }
        }

        public string Nationalite
        {
            get { return _citizen; }
            set
            {
                if (_citizen != value)
                {
                    _citizen = value;
                    RaisePropertyChanged(nameof(Nationalite));
                }
            }
        }

    }
}
