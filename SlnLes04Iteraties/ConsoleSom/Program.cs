using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSom
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int getal;

            int som = 0;


            Console.WriteLine("Voer een getal in (q om te stoppen): ");


            string input = Console.ReadLine();


            do

            {

                if (Int32.TryParse(input, out getal))

                {

                    som += getal;

                }

                else if (input.ToLower() != "q")

                {

                    Console.WriteLine("Ongeldige invoer. Probeer opnieuw.");

                }


                if (input.ToLower() != "q")

                {

                    Console.WriteLine("Voer een getal in (q om te stoppen): ");

                    input = Console.ReadLine();

                }

            } while (input.ToLower() != "q");


            Console.WriteLine("De som is: " + som);

            Console.ReadKey();

        }

    }

}

