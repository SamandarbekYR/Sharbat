using Amazon.Auth.AccessControlPolicy;
using Effort.Internal.TypeGeneration;
using Sharbat.Helper;
using System;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Controls;
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
                if ( tb1.Text.Length > 0 && tb2.Text.Length > 0)
                {
                    var result = 1 - (tb1.ParseDouble() / tb2.ParseDouble() * 100 );
                    Javob.Content = Math.Round(result,2);

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
            tb1.Text = "";
            tb2.Text = "";
            Javob.Content = "0.00";
        }

        private void btnInfo(object sender, RoutedEventArgs e)
        {

            string pdfFilePath = @"Doc.docx"; // Faylni to'liq yo'lini yozing

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "explorer.exe"; // Microsoft Word ilovasini ishga tushiramiz
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
