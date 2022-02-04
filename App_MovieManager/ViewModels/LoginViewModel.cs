using AdoToolbox;
using App_MovieManager.Models;
using App_MovieManager.Tools;
using App_MovieManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MovieManager.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel()
        {
            Email = "";
            Passwd = "";
            MessageErreur = "";
        }

        private DBservices _db = new DBservices();

        private int _idUser;
        private string _nom;
        private string _prenom;
        private string _email;
        private string _passwd;
        private string _nickname;
        private string _messageErreur;
        private CommandBase _signInCommand;

        public int IdUser
        {
            get { return _idUser; }
            set
            {
                if (_idUser != value)
                {
                    _idUser = value;
                    RaisePropertyChanged(nameof(IdUser));
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

        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    RaisePropertyChanged(nameof(Email));
                }
            }
        }

        public string Passwd
        {
            get { return _passwd; }
            set
            {
                if (_passwd != value)
                {
                    _passwd = value;
                    RaisePropertyChanged(nameof(Passwd));
                }
            }
        }

        public string Nickname
        {
            get { return _nickname; }
            set
            {
                if (_nickname != value)
                {
                    _nickname = value;
                    RaisePropertyChanged(nameof(Nickname));
                }
            }
        }

        public string MessageErreur
        {
            get { return _messageErreur; }
            set
            {
                if (_messageErreur != value)
                {
                    _messageErreur = value;
                    RaisePropertyChanged(nameof(MessageErreur));
                }
            }
        }


        public CommandBase SignInCommand
        {
            get { return _signInCommand ?? (_signInCommand = new CommandBase(SignIn)); }
        }


        public void SignIn()
        {
            if (! _db.CheckUserExist(Email, Passwd))  // todo: boucle => si user existe pas => messageErreur
                return;

            //ListeFilmsWindow nw = new ListeFilmsWindow();
            //ListeActeursWindow nw = new ListeActeursWindow();
            DGtestWindow dg = new DGtestWindow();
            HomeWindow hw = new HomeWindow();

            dg.Show();
            hw.Show();

        }
    }
}
