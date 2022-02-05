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

namespace App_MovieManager.Views
{
    /// <summary>
    /// Logique d'interaction pour Page_Acteurs.xaml
    /// </summary>
    public partial class Page_Acteurs : Page
    {
        public Page_Acteurs()
        {
            InitializeComponent();
        }

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
