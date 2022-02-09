using App_MovieManager.Tools;
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
        private List<UserControl> _pages;

        public AppWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            _pages = new List<UserControl>()
            {
                new Home(),
                new Collection(),
                new Favoris(),
                new Corbeille(),
                new Films(),
                new Acteurs(),
                new CreerFilm()
            };
            GridPage.Children.Add(_pages[0]);
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

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is ICloseWindow vm)
                vm.Close += () => this.Close();
        }

        // Pages Navigation
        private void ChangePage(object sender, RoutedEventArgs e)
        {
            GridPage.Children.Clear();
            int index = MenuBtn.Children.IndexOf(sender as Button);
            GridPage.Children.Add(_pages[index]);
        }

    }
}
