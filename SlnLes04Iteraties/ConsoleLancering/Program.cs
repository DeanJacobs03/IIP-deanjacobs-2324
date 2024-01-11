using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLancering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel seconden tot de lancering? ");
            int seconden = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{seconden}...");


            for (int i = seconden - 1; i >= 0; i--)

            {

                System.Threading.Thread.Sleep(1000);

                Console.WriteLine($"{i}...");

            }


            Console.WriteLine("Lift off!");
            Console.ReadKey();
        }

        
    }
    }

