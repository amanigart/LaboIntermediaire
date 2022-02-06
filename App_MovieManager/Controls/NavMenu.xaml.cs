using App_MovieManager.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace App_MovieManager.Controls
{
    /// <summary>
    /// Logique d'interaction pour NavMenu.xaml
    /// </summary>
    public partial class NavMenu : UserControl
    {
        public NavMenu()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click_ViewMovies(object sender, RoutedEventArgs e)
        {
            ListeFilmsWindow nw = new ListeFilmsWindow();
            nw.Show();
            //Page_Home ph = new Page_Home();
            //this.Content = ph;
        }

        private void Hyperlink_Click_ViewActors(object sender, RoutedEventArgs e)
        {
            ListeActeursWindow aw = new ListeActeursWindow();
            aw.Show();
            //Page_Acteurs pa = new Page_Acteurs();
            //this.Content = pa;
        }

        private void Hyperlink_Click_CreateMovie(object sender, RoutedEventArgs e)
        {
            CreerFilmWindow cw = new CreerFilmWindow();
            cw.Show();
        }

        private void Hyperlink_Click_ModifyMovie(object sender, RoutedEventArgs e)
        {
            ModifierFilmWindow mw = new ModifierFilmWindow();
            mw.Show();
        }


    }
}
