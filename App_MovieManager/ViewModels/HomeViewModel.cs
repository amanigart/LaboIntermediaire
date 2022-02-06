using App_MovieManager.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MovieManager.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {

        private CommandBase _closeWindowCommand;
        private CommandBase _minimizeWindowCommand;

        public Action Close { get; set; }
        public Action Minimize { get; set; }
        public CommandBase CloseWindowCommand
        {
            get { return _closeWindowCommand ?? (_closeWindowCommand = new CommandBase(CloseWindow)); }
        }
        public CommandBase MinimizeWindowCommand
        {
            get { return _minimizeWindowCommand ?? (_minimizeWindowCommand = new CommandBase(MinimizeWindow)); }
        }

        public void CloseWindow()
        {
            Close?.Invoke();
        }
        public void MinimizeWindow()
        {
            Minimize?.Invoke();
        }


    }
}
