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

namespace Sharbat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClos(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMaximized(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else WindowState = WindowState.Maximized;
        }

        private void btnMinimized(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnHisoblash(object sender, RoutedEventArgs e)
        {
            double shaftoli,shakar;
            if(tbS.Text.Length> 0 && tbM.Text.Length>0 && tbX.Text.Length>0)
            {
                shakar = (double.Parse(tbS.Text) * double.Parse(tbM.Text)) / (100-double.Parse( tbX.Text));
                shaftoli = (double.Parse(tbS.Text) * 100) / (100 - double.Parse(tbX.Text));

                lbT3.Content= shaftoli.ToString();
                lbTsh.Content= shakar.ToString();
            }
            else
            {
                MessageBox.Show("Malumotlarni to'liq kiriting!");
            }
        }
    }
}
