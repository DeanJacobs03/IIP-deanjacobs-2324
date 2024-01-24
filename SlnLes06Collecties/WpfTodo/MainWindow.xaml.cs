using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfTodo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ListBoxItem> listRemoved = new List<ListBoxItem>();
        SolidColorBrush[] prioKleuren = { Brushes.DarkGreen, Brushes.DarkOrange, Brushes.DarkRed };
        public MainWindow()
        {
            InitializeComponent();
            cmbPrio.SelectedIndex = 0;
        }

        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            string tekst = txtbTaak.Text;
            ListBoxItem lbi = new ListBoxItem();
            lbi.Content = tekst;

            string[] prioriteitLabels = { "laag", "gemiddeld", "hoog" };
            int index = -1;

            string priorKleineLetters = cmbPrio.Text.ToLower();

            if (priorKleineLetters == "laag")
            {
                index = 0;
            }
            else if (priorKleineLetters == "gemiddeld")
            {
                index = 1;
            }
            else if (priorKleineLetters == "hoog")
            {
                index = 2;
            }

            if (index >= 0 && index < prioKleuren.Length)
            {
                lbi.Foreground = prioKleuren[index];
            }
            else
            {
                lbi.Foreground = Brushes.Black;
            }

            lstLijst.Items.Add(lbi);
        }

        private void BtnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            listRemoved.Add((ListBoxItem)lstLijst.SelectedItem);

            lstLijst.Items.Remove(lstLijst.SelectedItem);
        }

        private void BtnTerugzetten_Click(object sender, RoutedEventArgs e)
        {
            if (listRemoved.Count > 0)
            {
                ListBoxItem lbi = listRemoved.Last();
                lstLijst.Items.Add(lbi);
                listRemoved.Remove(lbi);
            }
        }
        private void StatusUpdateKnop()
        {
            BtnVerwijderen.IsEnabled = lstLijst.SelectedItem != null;
            BtnTerugzetten.IsEnabled = listRemoved.Count > 0;
        }
    }
}
