using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKwisvraag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions = { "Welk jaar werd de Eerste Franse Republiek gesticht?", "Welk jaar werd de Amerikaanse Onafhankelijkheidsverklaring aangenomen?", "Welk jaar werd de Verlichting ingevoerd in Rusland?" };
            int[] correctAnswers = { 1791, 1776, 1700 };
            int userAnswer;
            bool userIsCorrect;

            for (int i = 0; i < questions.Length; i++)
            {
                for (int attempt = 0; attempt < 3; attempt++) // Herhaal de vraag maximaal drie keer
                {
                    Console.WriteLine(questions[i]);
                    userAnswer = Convert.ToInt32(Console.ReadLine());
                    userIsCorrect = userAnswer == correctAnswers[i];

                    if (userIsCorrect)
                    {
                        Console.WriteLine("Correct!");
                        break; // Als de gebruiker het juiste antwoord heeft ingevoerd, sluiten we de lus af
                    }
                    else if (attempt < 2) // Als het nog geen de laatste kans is, tonen we een foutmelding
                    {
                        Console.WriteLine($"Fout! Je hebt nog {2 - attempt} kans(en).");
                    }
                    else // Als het de laatste kans is, tonen we het juiste antwoord
                    {
                        Console.WriteLine($"Fout! Het correcte antwoord is {correctAnswers[i]}.");
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}
