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
    /// Logique d'interaction pour AppWindow.xaml
    /// </summary>
    public partial class AppWindow : Window
    {
        public AppWindow()
        {
            InitializeComponent();
        }

        // Fonctions Header Window
        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btn_Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Fonctions Navigation
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

        }

        private void Hyperlink_Click_ModifyMovie(object sender, RoutedEventArgs e)
        {


        }

        // Fonctions Searchbox
        private void EmptyTextboxOnFocus(object sender, RoutedEventArgs e)
        {
            TextBox tbox = (TextBox)sender;
            tbox.Text = string.Empty;
            tbox.GotFocus -= EmptyTextboxOnFocus;
        }

        private void ResetTextboxLostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tbox = (TextBox)sender;
            tbox.Text = "Rechercher...";
            tbox.LostFocus += ResetTextboxLostFocus;
        }
    }
}
