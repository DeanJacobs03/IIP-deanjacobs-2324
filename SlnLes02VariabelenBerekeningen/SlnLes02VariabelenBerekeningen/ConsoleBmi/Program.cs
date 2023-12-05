using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBmi
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

            Console.ReadKey();

        }
    }
}
