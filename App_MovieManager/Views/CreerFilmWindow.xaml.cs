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
    /// Logique d'interaction pour CreerFilmWindow.xaml
    /// </summary>
    public partial class CreerFilmWindow : Window
    {
        public CreerFilmWindow()
        {
            InitializeComponent();
            Loaded += HomeWindow_Loaded;
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

        private void HomeWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is ICloseWindow vmc)
                vmc.Close += () => this.Close();
        }
    }
}
