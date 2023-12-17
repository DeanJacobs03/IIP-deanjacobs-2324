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

namespace WpfBieden
{
    public partial class MainWindow : Window
    {
        
        private int HoogsteBod = 0;

        private string HoogsteBieder = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBod_Click(object sender, RoutedEventArgs e)
        {
            string naam = txtNaam.Text;

            if (int.TryParse(txtBod.Text, out int bod))
            {
                txtBod.Clear();
                txtNaam.Clear();

                if (bod > HoogsteBod)
                {
                    HoogsteBod = bod;
                    HoogsteBieder = naam;
                    lblFeedback.Content = $"{naam} heeft met {bod} euro nu het hoogste bod!";
                }
                else
                {
                    lblFeedback.Content = $"Sorry, {HoogsteBieder} heeft momenteel het hoogste bod.";
                }
            }
        }
    }
}
