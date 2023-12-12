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

namespace WpfWinkel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const double PrijsBanaan = 2.2;
        const double PrijsBoter = 3.05;
        const double PrijsEieren = 2.75;

        int BeschikbareBanaan;
        int BeschikbareBoter;
        int BeschikbareEieren;
        double Totaalprijs;

        public MainWindow()
        {
            InitializeComponent();
            InitializeWinkel();
        }

        private void InitializeWinkel()
        {
            Random rnd = new Random();

            BeschikbareBanaan = rnd.Next(5, 40);
            BeschikbareBoter = rnd.Next(5, 40);
            BeschikbareEieren = rnd.Next(5, 40);

            UpdateLabels();
        }

        private void UpdateLabels()
        {
            //update prijzen labels
            lblPrijsBanaan.Content = $"{PrijsBanaan} euro";
            lblPrijsBoter.Content = $"{PrijsBoter} euro";
            lblPrijsEieren.Content = $"{PrijsEieren} euro";

            //update beschikbare hoeveelheden labels
            overBanaan.Content = $"{BeschikbareBanaan} over";
            overBoter.Content = $"{BeschikbareBoter} over";
            overEieren.Content = $"{BeschikbareEieren} over";
        }

        private void btnBanaan_Click(object sender, RoutedEventArgs e)
        {
            VoegToeAanWinkel("bananen", PrijsBanaan, ref BeschikbareBanaan);
        }

        private void btnBoter_Click(object sender, RoutedEventArgs e)
        {
            VoegToeAanWinkel("boter", PrijsBoter, ref BeschikbareBoter);
        }

        private void btnEieren_Click(object sender, RoutedEventArgs e)
        {
            VoegToeAanWinkel("eieren", PrijsEieren, ref BeschikbareEieren);
        }

        private void VoegToeAanWinkel(string product, double prijs, ref int beschikbaar)
        {
            beschikbaar--;
            Totaalprijs += prijs;
            UpdateLabels();

            string item = $"{prijs} - 1 " +
                          (product.ToLower() == "boter" ? "pak" :
                           product.ToLower() == "eieren" ? "doos" : "tros") +
                          $" {product}";

            listWinkel.Items.Add(item);
            btnAfrekenen.IsEnabled = true;
        }


        private void btnAfrekenen_Click(object sender, RoutedEventArgs e)
        {
            lblTotaalprijs.Content = $"{Totaalprijs:C}";
        }

        private void btnHerstart_Click(object sender, RoutedEventArgs e)
        {
            InitializeWinkel();
            listWinkel.Items.Clear();
            Totaalprijs = 0;
            UpdateLabels();
            btnAfrekenen.IsEnabled = false;
            lblTotaalprijs.Content = "";
        }
    }
}
