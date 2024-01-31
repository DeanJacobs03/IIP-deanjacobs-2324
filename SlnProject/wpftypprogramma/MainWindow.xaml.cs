using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace WpfTypProgramma
{
    public partial class MainWindow : Window
    {
        private static string[] engelsezin = { "Arrived compass prepare an on as.", "Man request adapted spirits set pressed." };
        private static string[] nederlandsezin = { "Sedert jaren vraag ik mij af, waartoe zulke dingen dienen, en ik sta verbaasd over de onbeschaamdheid, waarmee een dichter of romanverteller u iets op de mouw durft spelden, dat nooit gebeurd is, en meestal niet gebeuren kan.", "Dat zijn ook makelaars in koffie, doch hun adres behoeft ge niet te weten. Ik pas er dus wel op, dat ik geen romans schrijf, of andere valse opgaven doe. Ik heb dan ook altijd opgemerkt dat mensen die zich met zoiets inlaten, gewoonlijk slecht wegkomen. Ik ben drieënveertig jaar oud, bezoek sedert twintig jaren de beurs, en kan dus voor de dag treden, als men iemand roept die ondervinding heeft." };
        private static string[] fransezin = { "Le client est très important merci, le client sera suivi par le client. Énée n'a pas de justice, pas de résultat, pas de ligula, et la vallée veut la sauce. Morbi mais qui veut vendre une couche de contenu triste d'internet. Être ivre maintenant, mais ne pas être ivre maintenant, mon urne est d'une grande beauté, mais elle n'est pas aussi bien faite que dans un livre.", "Mécène dans la vallée de l'orc, dans l'élément même. Certaines des exigences faciles du budget, qu'il soit beaucoup de temps pour dignissim et. Je ne m'en fais pas chez moi, ça va être moche dans le vestibule. Mais aussi des protéines de Pour avant la fin de la semaine, qui connaît le poison, le résultat." };
        private static Random rnd = new Random();
        private static int foutTekenTeller = 0;
        private static int totaalTekenTeller = 0;
        private static Stopwatch stopwatch;
        private static MediaPlayer correctGeluid;
        private static MediaPlayer verkeerdGeluid;

        public MainWindow()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            correctGeluid = new MediaPlayer();
            correctGeluid.Open(new Uri("sound//correct.mp3", UriKind.Relative));
            verkeerdGeluid = new MediaPlayer();
            verkeerdGeluid.Open(new Uri("sound//wrong.mp3", UriKind.Relative));
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                string zin = GenereerZin(radioButton.Name);
                txbZin.Text = zin;
            }
        }

        private string GenereerZin(string taal)
        {
            int index;
            switch (taal)
            {
                case "RbEngels":
                    index = rnd.Next(0, engelsezin.Length);
                    return engelsezin[index];
                case "RbNederlands":
                    index = rnd.Next(0, nederlandsezin.Length);
                    return nederlandsezin[index];
                case "RbFrans":
                    index = rnd.Next(0, fransezin.Length);
                    return fransezin[index];
                default:
                    Console.WriteLine("Ongeldige keuze. Valt standaard terug naar engels.");
                    index = rnd.Next(0, engelsezin.Length);
                    return engelsezin[index];
            }
        }

        private void TextBoxInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            string zin = txbZin.Text;
            string getypteTekst = txbTypen.Text;

            if (!stopwatch.IsRunning)
            {
                stopwatch.Start();
            }

            totaalTekenTeller++;

            UpdateZin(zin, getypteTekst);

            if (getypteTekst.Equals(zin))
            {
                stopwatch.Stop();
                TimeSpan timeSpan = stopwatch.Elapsed;
                PrintScoreBord(timeSpan);
            }
        }

        private void UpdateZin(string zin, string getypteTekst)
        {
            txbZin.Inlines.Clear();

            for (int i = 0; i < zin.Length; i++)
            {
                Run run = new Run(zin[i].ToString());

                if (i < getypteTekst.Length)
                {
                    if (getypteTekst[i] == zin[i])
                    {
                        run.Foreground = Brushes.Green;
                    }
                    else
                    {
                        foutTekenTeller++;
                        run.Foreground = Brushes.Red;
                    }
                }

                txbZin.Inlines.Add(run);
            }
        }

        private void PrintScoreBord(TimeSpan timeSpan)
        {
            double foutPercentage = Math.Round((double)foutTekenTeller / (double)totaalTekenTeller * 100, 2);
            double totaalTijdSeconden = Math.Round(timeSpan.TotalSeconds, 2);
            double gemiddeldToetsaanslagen = Math.Round(timeSpan.TotalSeconds / totaalTekenTeller, 2);

            string scoreBord = $"Het aantal fouten bedraagt: {foutTekenTeller}.\n" +
                                $"Fout percentage: {foutPercentage}%.\n" +
                                $"Totale tijd: {totaalTijdSeconden}s.\n" +
                                $"Gemiddelde tijd per toetsindruk: {gemiddeldToetsaanslagen}s.";

            labelScore.Content = scoreBord;
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            stopwatch.Stop();
            TimeSpan timeSpan = stopwatch.Elapsed;
            PrintScoreBord(timeSpan);
        }
    }
}
