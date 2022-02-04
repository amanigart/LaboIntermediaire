using App_MovieManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace App_MovieManager.Views
{
    /// <summary>
    /// Logique d'interaction pour ListeFilmsWindow.xaml
    /// </summary>
    public partial class ListeFilmsWindow : Window
    {
        public ListeFilmsWindow()
        {
            InitializeComponent();
            DataContext = new ListeFilmsViewModel();
        }
    }
}
