using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace raden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef twee gehele getallen");
            Console.Write("- getal 1: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("- getal 2: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());




            if (getal1 > getal2) {
                int getal3 = getal1;
                getal1 = getal2;
                getal2 = getal3;
            }

            Random rand = new Random();
            int correctgetal = rand.Next(getal1, getal2);

            Console.WriteLine("Doe een gok: ");
            int gok = Convert.ToInt32(Console.ReadLine());

            if (correctgetal == gok)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Juist");
                Console.ResetColor();
            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fout");
                Console.ResetColor();
                if (Math.Abs(gok - correctgetal)  <= 2)
                {
                    Console.WriteLine("Dichtbij");
                }
            }


            
            
            Console.ReadKey();
        }
    }
}
