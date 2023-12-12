using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAbonnement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine(@"Bestelgegevens");
            Console.WriteLine(@"============== ");

            Console.Write("- Naam klant: ");
            string naam_klant = Console.ReadLine();

            Console.Write("- aantal toegangsbeurten: ");
            int beurten = Convert.ToInt32(Console.ReadLine());

            Console.Write("- prijs (b.v. 122,5): ");
            double prijs = Convert.ToDouble(Console.ReadLine());

            Console.Write("- badkledij inbegrepen (typ true of false): ");
            bool kledij = Convert.ToBoolean(Console.ReadLine());

            Console.Write("- geslacht (druk 'm' of 'v'):");
            char geslacht = Console.ReadKey().KeyChar;

            Random rnd = new Random();

            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Write(@"Samenvatting
============");

            Console.WriteLine();

            Console.WriteLine($@"- houder: {naam_klant}
- geslacht: {geslacht}
- prijs: €{prijs}
- aantal beurten: {beurten}
- incl. badkledij: {kledij}
- kaartnummer: {rnd.Next(100, 1000)}-{rnd.Next(1000, 10000)}-{rnd.Next(10, 100)}");
            
            Console.ReadKey();
        }
    }
        }