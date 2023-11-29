using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHalloWereld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo wereld!");
            Console.Write("Hoe heet je:");
            string naam = Console.ReadLine();
            Console.Write("Aangename kennismaking, ");
            Console.WriteLine(naam);
            Console.WriteLine("druk een toets om verder te gaan...");
            Console.ReadKey();
        }
    }
}
