using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleGangsterName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
************************
| GANSTA NAME BUILDER  |
************************");


            Console.WriteLine();
            Console.WriteLine();


            Console.Write("Give the first name of any Disney character: ");
            string character = Console.ReadLine();


            Console.Write("Give any workbench tool: ");
            string tool = Console.ReadLine();


            Console.Write("What is your last name: ");
            string naam = Console.ReadLine();

            string ganstaName = character + " " + "'the " + tool + "'" + " " + naam;

            Console.WriteLine();

            Console.Write("Your gansta name: ");
            
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write(ganstaName);

            Console.ReadKey();


        }
    }
}
