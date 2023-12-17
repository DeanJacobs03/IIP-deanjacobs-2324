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

namespace WpfFormChecking
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            int Fouten = 0;

            if (string.IsNullOrEmpty(TxtNaam.Text))
            {
                LblMessageName.Content = "naam moet ingevuld zijn";
                Fouten++;
            }
            else
            {
                LblMessageName.Content = "";
            }

            if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                LblMessageEmail.Content = "email moet ingevuld zijn";
                Fouten++;
            }
            else
            {
                LblMessageEmail.Content = "";
            }

            if (DatGeboorte.SelectedDate == null)
            {
                LblMessageGeboorte.Content = "datum moet ingevuld zijn";
                Fouten++;
            }
            else
            {
                LblMessageGeboorte.Content = "";
            }

            if (LstProfiel.SelectedIndex == 0)
            {
                LblMessageProfiel.Content = "maak een keuze";
                Fouten++;
            }
            else
            {
                LblMessageProfiel.Content = "";
            }

            if (string.IsNullOrEmpty(PwdPaswoord.Password))
            {
                LblMessagePaswoord.Content = "kies een paswoord";
                Fouten++;
            }
            else
            {
                LblMessagePaswoord.Content = "";
            }

            if (!rbnMan.IsChecked.Value && !rbnVrouw.IsChecked.Value)
            {
                LblMessageGeslacht.Content = "kies een geslacht";
                Fouten++;
            }
            else
            {
                LblMessageGeslacht.Content = "";
            }

            if (!chbProgrammeren.IsChecked.Value && !chbNetwerken.IsChecked.Value && !chbBusiness.IsChecked.Value)
            {
                LblMessageInteresses.Content = "kies minstens één interesse";
                Fouten++;
            }
            else
            {
                LblMessageInteresses.Content = "";
            }

            LblNumFouten.Content = Fouten > 0 ? $"dit formulier bevat {Fouten} fouten" : "Formulier is correct ingevuld";
        }


        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            TxtNaam.Text = "";
            TxtEmail.Text = "";
            DatGeboorte.SelectedDate = null;
            LstProfiel.SelectedIndex = 0;
            PwdPaswoord.Password = "";
            rbnMan.IsChecked = false;
            rbnVrouw.IsChecked = false;
            chbProgrammeren.IsChecked = false;
            chbNetwerken.IsChecked = false;
            chbBusiness.IsChecked = false;



            LblMessageName.Content = "";
            LblMessageEmail.Content = "";
            LblMessageGeboorte.Content = "";
            LblMessageProfiel.Content = "";
            LblMessagePaswoord.Content = "";
            LblMessageGeslacht.Content = "";
            LblMessageInteresses.Content = "";
            LblNumFouten.Content = "";
        }
    }
}