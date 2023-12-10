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

namespace WpfBmi
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

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double gewicht = Convert.ToDouble(TxbGewicht.Text);
            double lengte_cm = Convert.ToDouble(TxbLengte.Text);

            double lengte = lengte_cm / 100;

            double bmi = gewicht / (lengte * lengte);

            double AfgerondBmi = Math.Round(bmi, 1);

            LblBmi.Content = $"{AfgerondBmi}"; 
        }
    }
}
