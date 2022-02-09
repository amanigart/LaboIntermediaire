using App_MovieManager.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MovieManager.ViewModels
{
    public class RegisterViewModel : ViewModelBase, ICloseWindow
    {
        private string _nom;
        private string _prenom;
        private string _email;
        private string _passwd;
        private string _nickname;
        private CommandBase _signUpCommand;

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
        public CommandBase SignUpCommand
        {
            get { return _signUpCommand ?? (_signUpCommand = new CommandBase(SignUp)); }
        }

        public void SignUp()
        {
            DBservices _dbreg = new DBservices();
            _dbreg.CreateUser(Nom, Prenom, Email, Passwd, Nickname);
            this.CloseWindow();
        }

        // Close Login Window Command
        private CommandBase _closeWindowCommand;
        public CommandBase CloseWindowCommand
        {
            get { return _closeWindowCommand ?? (_closeWindowCommand = new CommandBase(CloseWindow)); }
        }
        public Action Close { get; set; }
        public void CloseWindow()
        {
            Close?.Invoke();
        }
    }
}
