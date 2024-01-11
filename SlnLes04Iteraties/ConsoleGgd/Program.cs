using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGgd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"BEREKEN DE GROOTSTE GEMENE DELER
================================");
            Console.Write("Getal 1: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Getal 2: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());
            while (getal1 != getal2)
            {
                if (getal1 > getal2)
                {
                    getal1 = getal1 - getal2;
                }
                else
                {
                    getal2 = getal2 - getal1;
                }
            }
            Console.WriteLine($"De grootste gemene deler is {getal1}");
            Console.ReadKey();
        }
    }
}