using Amazon.Auth.AccessControlPolicy;
using Effort.Internal.TypeGeneration;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Windows;
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
            try
            {
                double shaftoli, shakar;
                if (tbS.Text.Length > 0 && tbM.Text.Length > 0 && tbX.Text.Length > 0)
                {
                    shakar = (double.Parse(tbS.Text) * double.Parse(tbM.Text)) / (100 - double.Parse(tbX.Text));
                    shaftoli = (double.Parse(tbS.Text) * 100) / (100 - double.Parse(tbX.Text));

                    lbT3.Content = Math.Round(shaftoli, 2);
                    lbTsh.Content = Math.Round(shakar, 2);
                }
                else
                {
                    MessageBox.Show("Malumotlarni to'liq kiriting", "Xatolik", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Malumotlarni nato'g'ri kiritdingiz!!!", "Xatolik", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnRefresh(object sender, RoutedEventArgs e)
        {
            tbM.Text = "";
            tbS.Text = "";
            tbX.Text = "";
        }

        private void btnInfo(object sender, RoutedEventArgs e)
        {

            string pdfFilePath = @"Sharbat.pdf"; // Faylni to'liq yo'lini yozing

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "winword.exe"; // Microsoft Word ilovasini ishga tushiramiz
            startInfo.Arguments = pdfFilePath; // Faylni tanlab ochish
            startInfo.UseShellExecute = true; // Kamandani standart operatsion tizim bilan ishlatish

            try
            {
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Faylni ochishda xatolik yuz berdi: " + ex.Message, "Xatolik", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        private void dragMove(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
