using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBuffet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            const double SeizoensBuffet = 18.5;
            const double DessertenBuffets = 7.95;
            const double KidsMenu = 8.95;


            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine(@"WELKOM IN HET BUFFETRESTAURANT
==============================");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Aantal seizoensbuffets (€18.5)");
            double XBuffet = Convert.ToDouble(Console.Read());



            Console.ReadKey();
        }
    }
}
