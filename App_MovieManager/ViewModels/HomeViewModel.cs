using App_MovieManager.Tools;
using App_MovieManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MovieManager.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public HomeViewModel()
        {
            _query = "";
        }

        private string _query;
        public string Query
        {
            get => _query;
            set
            {
                if (_query != value)
                {
                    _query = value;
                    RaisePropertyChanged(nameof(Query));
                }
            }
        }

        private CommandBase _searchCommand;

        public CommandBase SearchCommand
        {
            get { return _searchCommand ?? (_searchCommand = new CommandBase(Search)); }
        }


        public void Search()
        {
            SearchResultsViewModel svm = new SearchResultsViewModel(Query);
            //QueryResultsWindow qw = new QueryResultsWindow(Query);
        }



    }
}
