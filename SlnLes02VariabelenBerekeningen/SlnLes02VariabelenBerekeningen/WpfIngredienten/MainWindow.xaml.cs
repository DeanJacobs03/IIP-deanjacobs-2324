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

namespace WpfIngredienten
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

        private void BtnLijst_Click(object sender, RoutedEventArgs e)
        {
            int AantalPers = Convert.ToInt32(TxbAantalpers.Text);

            double Hvl1 = Convert.ToDouble(TxbHvl1.Text);
            double Hvl2 = Convert.ToDouble(TxbHvl2.Text);
            double Hvl3 = Convert.ToDouble(TxbHvl3.Text);
            double Hvl4 = Convert.ToDouble(TxbHvl4.Text);

            string Un1 = TxbUn1.Text;
            string Un2 = TxbUn2.Text;
            string Un3 = TxbUn3.Text;
            string Un4 = TxbUn4.Text;

            string Ing1 = TxbIng1.Text;
            string Ing2 = TxbIng2.Text;
            string Ing3 = TxbIng3.Text;
            string Ing4 = TxbIng4.Text;

            double TotaalHvl1 = Hvl1 * AantalPers;
            double TotaalHvl2 = Hvl2 * AantalPers;
            double TotaalHvl3 = Hvl3 * AantalPers;
            double TotaalHvl4 = Hvl4 * AantalPers;

            TxbLijst.Text = ($@"
- {TotaalHvl1} {Un1} {Ing1}
- {TotaalHvl2} {Un2} {Ing2}
- {TotaalHvl3} {Un3} {Ing3}
- {TotaalHvl4} {Un4} {Ing4}");



        }
    }
}
