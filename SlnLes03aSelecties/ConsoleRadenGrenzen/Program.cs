using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRadenGrenzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"                   .___             
____________     __| _/____   ____  
\_  __ \__  \   / __ |/ __ \ /    \ 
 |  | \// __ \_/ /_/ \  ___/|   |  \
 |__|  (____  /\____ |\___  >___|  /
            \/      \/    \/     \/ 
                                    
                                    
                                    
                                    
                                    
                                    ");

            Console.WriteLine("Geef twee gehele getallen.");

            Console.Write("- getal 1: ");
            int ondergrens = int.Parse(Console.ReadLine());

            Console.Write("- getal 2: ");
            int bovengrens = int.Parse(Console.ReadLine());

            if (ondergrens > bovengrens)
            {
                Console.WriteLine("Ondergrens mag niet groter zijn dan bovengrens. Grenzen worden verwisseld.");
                int temp = ondergrens;
                ondergrens = bovengrens;
                bovengrens = temp;
            }

            Random randomGenerator = new Random();
            int willekeurigGetal = randomGenerator.Next(ondergrens, bovengrens + 1); 

            Console.Write("Doe een gok: ");
            int gok = int.Parse(Console.ReadLine());

            if (gok == willekeurigGetal)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("JUIST! Goed geraden!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FOUT! Het juiste getal was: " + willekeurigGetal);

                int verschil = Math.Abs(willekeurigGetal - gok);
                if (verschil <= 2)
                {
                    Console.WriteLine("Je zat er nochtans niet ver af!");
                }
            }

            Console.ReadKey();

            Console.ResetColor(); 
        }

 
        }
    }
