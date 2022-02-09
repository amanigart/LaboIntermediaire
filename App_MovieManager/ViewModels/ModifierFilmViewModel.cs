using App_MovieManager.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MovieManager.ViewModels
{
    public class ModifierFilmViewModel : ViewModelBase
    {
        private DBservices _db = new DBservices();

        public Dictionary<int, string> ListeRealisateurs { get; set; }

        //// Commande Enregistrer update film
        //private CommandBase _saveMovieModifyCommand;
        //public CommandBase SaveMovieModifyCommand
        //{
        //    get { return _saveMovieModifyCommand ?? (_saveMovieModifyCommand = new CommandBase(SaveMovieModify)); }
        //}

        //public void SaveMovieModify()
        //{
        //    MainWindow mw = new MainWindow();
        //    mw.Show();
        //    //_db.UpdateModifyMovie("test");

        //}
    }
}
