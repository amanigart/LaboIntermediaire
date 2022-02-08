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
    public class AppViewModel : ViewModelBase, ICloseWindow
    {
        public AppViewModel()
        {
            User = Session.CurrentUser;
        }
        
        // Session User
        public Utilisateur User { get; set; }


        // Logout Command
        private CommandBase _logOutCommand;
        public CommandBase LogOutCommand { get => _logOutCommand ?? (_logOutCommand = new CommandBase(LogOut)); }
        public void LogOut()
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close?.Invoke();
        }


        // Close App Window Command
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


        // Minimize App Window Command
        //private CommandBase _minimizeWindowCommand;
        //public Action Minimize { get; set; }
        //public CommandBase MinimizeWindowCommand
        //{
        //    get { return _minimizeWindowCommand ?? (_minimizeWindowCommand = new CommandBase(MinimizeWindow)); }
        //}
        //public void MinimizeWindow()
        //{
        //    Minimize?.Invoke();
        //}

    }
}
