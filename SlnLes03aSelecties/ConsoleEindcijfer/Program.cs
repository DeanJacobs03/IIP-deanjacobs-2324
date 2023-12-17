using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEindcijfer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Berekening eindcijfer
=====================");


            Console.Write("Geef het cijfer dagelijks werk (op 20): ");
            double DagelijksWerk = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geef het cijfer op het project (op 20): ");
            double Project = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geef het cijfer op het examen (op 20): ");
            double Examen = Convert.ToDouble(Console.ReadLine());

           
            double totaal = (DagelijksWerk / 20) * 30 + Project + (Examen / 20) * 50;

            
            if (Examen < 8)
            {
                double examenpunt = Examen * 5;
                totaal = Math.Min(totaal, examenpunt);
            }

            Console.WriteLine();
            Console.WriteLine($"Je eindcijfer is {Math.Round(totaal, 1)}%");

            Console.WriteLine();

            // comment toevoegen bv. voldoende
            if (totaal < 50)
            {
                Console.WriteLine("-> onvoldoende");
            }
            else if (totaal <= 67.5)
            {
                Console.WriteLine("-> voldoende");
            }
            else if (totaal <= 75)
            {
                Console.WriteLine("-> onderscheiding");
            }
            else if (totaal <= 82.5)
            {
                Console.WriteLine("-> grote onderscheiding");
            }
            else if (totaal > 82.5)
            {
                Console.WriteLine("-> grootste onderscheiding");
            }

            Console.ReadKey();
        }
    }
}
