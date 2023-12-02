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

namespace WpfPrijsvraag
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

        private void Rdb1_Checked(object sender, RoutedEventArgs e)
        {
            TxbCorrectie.Text = ("fout");
        }

        private void Rdb2_Checked(object sender, RoutedEventArgs e)
        {
            TxbCorrectie.Text = ("");
            TxbCorrectie.Text = ("Juist! Je mag hier onder een prijs kiezen.");
        }

        private void Rdb3_Checked(object sender, RoutedEventArgs e)
        {
            TxbCorrectie.Text = ("");
            TxbCorrectie.Text = ("fout");
        }

        private void Rdb4_Checked(object sender, RoutedEventArgs e)
        {
            TxbCorrectie.Text = ("");
            TxbCorrectie.Text = ("fout");
        }

        private void Rdb5_Checked(object sender, RoutedEventArgs e)
        {
            LblPrijs.Content = ("Uitstekende keuze! Dankzij deze hoogwaardige slijpschijf kan u eindelijk die lelijke schouwmantel uitbreken.");
            ImgCadeau.Source = new BitmapImage(new Uri("C:\\Users\\Dean\\Desktop\\Odisee\\introprogrammeren\\IIP-deanjacobs-2324\\SlnLes01VisualStudioEnWpf\\WpfPrijsvraag\\img\\slijpschijf.jpg", UriKind.Absolute));
        }

        private void Rdb6_Checked(object sender, RoutedEventArgs e)
        {
            LblPrijs.Content = ("Prima gekozen! Met deze stoomreiniger krijgt ongedierte geen kans meer tussen houten planken en hoeken in huis.");
            ImgCadeau.Source = new BitmapImage(new Uri("C:\\Users\\Dean\\Desktop\\Odisee\\introprogrammeren\\IIP-deanjacobs-2324\\SlnLes01VisualStudioEnWpf\\WpfPrijsvraag\\img\\stoomreiniger.jpg", UriKind.Absolute));
        }

        private void Rdb7_Checked(object sender, RoutedEventArgs e)
        {
            LblPrijs.Content = ("Mooie keuze! Dankzij deze tandenborstel met actieve borstelrotaties in zes programma's ruikt uw adem frisser dan ooit.");
            ImgCadeau.Source = new BitmapImage(new Uri("C:\\Users\\Dean\\Desktop\\Odisee\\introprogrammeren\\IIP-deanjacobs-2324\\SlnLes01VisualStudioEnWpf\\WpfPrijsvraag\\img\\tandenborstel.jpg", UriKind.Absolute));
        }

        
    }
}
