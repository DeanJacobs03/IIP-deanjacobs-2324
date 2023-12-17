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

namespace WpfSliderKleur
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SldWaarde.ValueChanged += SldWaarde_ValueChanged;

            UpdateLabelColor(SldWaarde.Value);
        }

        private void SldWaarde_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateLabelColor(e.NewValue);
        }

        private void UpdateLabelColor(double sliderValue)
        {
            double roundedValue = Math.Round(sliderValue);

            if (roundedValue < 30)
            {
                lblWaarde.Foreground = new SolidColorBrush(Colors.Green);
            }
            else if (roundedValue < 50)
            {
                lblWaarde.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            else if (roundedValue < 80)
            {
                lblWaarde.Foreground = new SolidColorBrush(Colors.DarkOrange);
            }
            else
            {
                lblWaarde.Foreground = new SolidColorBrush(Colors.DarkRed);
            }

            lblWaarde.Content = $"{roundedValue}";
        }
    }
}
