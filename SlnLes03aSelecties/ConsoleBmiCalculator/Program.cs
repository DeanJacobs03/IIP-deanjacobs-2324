using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBmiCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"BMI CALCULATOR
==============");

            Console.Write("Lengte (in cm): ");
            double cm = Convert.ToDouble(Console.ReadLine());

            Console.Write("Gewicht (in kg): ");
            double gewicht = Convert.ToDouble(Console.ReadLine());

            double lengte = cm / 100;

            double bmi = gewicht / (lengte * lengte);
            double BmiAfgerond = Math.Round(bmi, 1);
            Console.Write($"Je BMI bedraagt {BmiAfgerond}");

            Console.WriteLine();

            if (BmiAfgerond < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine();
                Console.WriteLine("Je hebt ondergewicht");
                Console.ResetColor();
            }
            else if (BmiAfgerond <= 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("Je gewicht is normaal");
                Console.ResetColor();
            }
            else if (BmiAfgerond <= 30)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine();
                Console.WriteLine("Je hebt overgewicht");
                Console.ResetColor();
            }
            else if (BmiAfgerond > 30)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("Je hebt obesitas");
                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}
