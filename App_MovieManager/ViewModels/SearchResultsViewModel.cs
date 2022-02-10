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
    public class SearchResultsViewModel : ViewModelBase
    {
        public SearchResultsViewModel(string query)
        {
            _listeFilms = new ObservableCollection<DetailFilmViewModel>();

            _listeFilmsEnum = _db.SearchMovielList(query);
            _listeFilms = new ObservableCollection<DetailFilmViewModel>();
            foreach (DetailFilm df in _listeFilmsEnum)
            {
                _listeFilms.Add(new DetailFilmViewModel(df));
            }
            QueryResultsWindow qw = new QueryResultsWindow();
            qw.Show();
        }

        private DBservices _db = new DBservices();
        private readonly IEnumerable<DetailFilm> _listeFilmsEnum;
        private ObservableCollection<DetailFilmViewModel> _listeFilms;
        public ObservableCollection<DetailFilmViewModel> ListeFilms
        {
            get { return _listeFilms; }
            set { _listeFilms = value;}
        }
    }
}
