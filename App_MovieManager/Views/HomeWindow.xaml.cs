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
    /// Logique d'interaction pour HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
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

        // Fonction SearchBox
        private void TextBlock_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Key == Key.Return)
            //{
            //    Page_Acteurs pa = new Page_Acteurs();
            //    this.Content = pa;
            //}
        }

        private void HomeWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is ICloseWindow vmc)
                vmc.Close += () => this.Close();

            //if (DataContext is IMinimizeWindow vmm)
            //    vmm.Minimize += () => this.WindowState = WindowState.Minimized;
        }
    }
}
