// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Typprogramma
{
    using System;
    using System.Diagnostics;
    using WMPLib;

    internal class Program
    {
        private static string[] engelseZin = { "Arrived compass prepare an on as.", "Man request adapted spirits set pressed." };
        private static string[] nederlandseZin = { "Sedert jaren vraag ik mij af, waartoe zulke dingen dienen, en ik sta verbaasd over de onbeschaamdheid, waarmee een dichter of romanverteller u iets op de mouw durft spelden, dat nooit gebeurd is, en meestal niet gebeuren kan.", "Dat zijn ook makelaars in koffie, doch hun adres behoeft ge niet te weten. Ik pas er dus wel op, dat ik geen romans schrijf, of andere valse opgaven doe. Ik heb dan ook altijd opgemerkt dat mensen die zich met zoiets inlaten, gewoonlijk slecht wegkomen. Ik ben drieënveertig jaar oud, bezoek sedert twintig jaren de beurs, en kan dus voor de dag treden, als men iemand roept die ondervinding heeft." };
        private static string[] franseZin = { "Le client est très important merci, le client sera suivi par le client. Énée n'a pas de justice, pas de résultat, pas de ligula, et la vallée veut la sauce. Morbi mais qui veut vendre une couche de contenu triste d'internet. Être ivre maintenant, mais ne pas être ivre maintenant, mon urne est d'une grande beauté, mais elle n'est pas aussi bien faite que dans un livre.", "Mécène dans la vallée de l'orc, dans l'élément même. Certaines des exigences faciles du budget, qu'il soit beaucoup de temps pour dignissim et. Je ne m'en fais pas chez moi, ça va être moche dans le vestibule. Mais aussi des protéines de Pour avant la fin de la semaine, qui connaît le poison, le résultat." };
        private static Random rnd = new Random();
        private static int foutTekenTeller = 0;
        private static int totaalTekenTeller = 0;
        private static TimeSpan timeSpan;

        private static void Main(string[] args)
        {
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
            Console.WriteLine("Kies een taal:");
            Console.WriteLine("1 Engels");
            Console.WriteLine("2 Nederlands");
            Console.WriteLine("3 Frans");

            string userinput = Console.ReadLine();
            string sentence = GenerateSentence(userinput);
            PrintSentence(sentence);
            PrintScoreBoard();

            Console.ReadKey();
            Environment.Exit(0);
        }

        private static string GenerateSentence(string userinput)
        {
            int index;
            switch (userinput)
            {
                case "1":
                    index = rnd.Next(0, engelseZin.Length);
                    return engelseZin[index];
                case "2":
                    index = rnd.Next(0, nederlandseZin.Length);
                    return nederlandseZin[index];
                case "3":
                    index = rnd.Next(0, franseZin.Length);
                    return franseZin[index];
                default:
                    Console.WriteLine("Ongeldige keuze. Valt standaard terug naar engels.");
                    index = rnd.Next(0, engelseZin.Length);
                    return engelseZin[index];
            }
        }

        private static void PrintSentence(string sentence)
        {
            string getypteTekst = string.Empty;
            bool escape = false;
            Stopwatch stopwatch = new Stopwatch();
            WindowsMediaPlayer wmPlayer = new WMPLib.WindowsMediaPlayer();
            wmPlayer.URL = "sound\\correct.mp3";
            Console.WriteLine(sentence);

            do
            {
                ConsoleKeyInfo ck = Console.ReadKey();
                if (!stopwatch.IsRunning)
                {
                    stopwatch.Start();
                }

                if (ck.Key == ConsoleKey.Escape)
                {
                    escape = true;
                }
                else if (ck.Key == ConsoleKey.Backspace)
                {
                    getypteTekst = getypteTekst.Remove(getypteTekst.Length - 1);
                    foutTekenTeller++;

                    UpdateZin(sentence, getypteTekst);
                }
                else
                {
                    totaalTekenTeller++;

                    char letter = ck.KeyChar;
                    if (letter.Equals(sentence[getypteTekst.Length]))
                    {
                        wmPlayer.controls.play();
                    }
                    else
                    {
                        foutTekenTeller++;
                        wmPlayer.URL = "sound\\wrong.mp3";
                        wmPlayer.controls.play();
                    }

                    getypteTekst += letter;

                    UpdateZin(sentence, getypteTekst);
                }
            }
            while (!sentence.Equals(getypteTekst) && !escape);
            stopwatch.Stop();

            timeSpan = stopwatch.Elapsed;

            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("gestopt met typen");
        }

        private static void UpdateZin(string sentence, string getypteTekst)
        {
            Console.Clear();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (getypteTekst.Length < i + 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (sentence[i] == getypteTekst[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.Write(sentence[i]);
            }
        }

        private static void PrintScoreBoard()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Het aantal fouten bedraagt: {foutTekenTeller}.");
            Console.WriteLine($"Fout percentage: {Math.Round((float)foutTekenTeller / (float)totaalTekenTeller * 100, 2)}%.");
            Console.WriteLine($"Totale tijd: {Math.Round(timeSpan.TotalSeconds, 2)}s.");
            Console.WriteLine($"Gemiddelde tijd per toetsindruk: {Math.Round(timeSpan.TotalSeconds / totaalTekenTeller, 2)}s.");
        }
    }
}
