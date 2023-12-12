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

namespace WpfGebruikersnaam
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

        private void TxbNaam_TextChanged(object sender, TextChangedEventArgs e)
        {
            string username = TxbNaam.Text;
            if (username.Length < 3)
            {
                LblFeedback.Content = "Moet minstens 3 tekens bevatten";
                TxbNaam.Background = Brushes.LightCoral;
            }
            else if (username.Contains(" "))
            {
                LblFeedback.Content = "Mag geen spatie bevatten";
                TxbNaam.Background = Brushes.LightCoral;
            }
            else if (!username.Any(char.IsUpper))
            {
                LblFeedback.Content = "Moet minstens 1 hoofdletter bevatten";
                TxbNaam.Background = Brushes.LightCoral;
            }
            else
            {
                TxbNaam.Background = Brushes.LightGreen;
            }
        }
    }
}
