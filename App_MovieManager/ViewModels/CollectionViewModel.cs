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
    public class CollectionViewModel : ViewModelBase
    {
        public CollectionViewModel()
        {
            User = Session.CurrentUser;
            _collectionList = new ObservableCollection<ViewCollection>(_db.GetCollection(User.IdUser));
        }

        public Utilisateur User { get; set; }

        private DBservices _db = new DBservices();

        private ObservableCollection<ViewCollection> _collectionList;
        public ObservableCollection<ViewCollection> CollectionList
        {
            get { return _collectionList; }
            set
            {
                if (_collectionList != value)
                {
                    _collectionList = value;
                    RaisePropertyChanged(nameof(CollectionList));
                }
            }
        }
    }
}
