using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMahjong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(@"
************************
| WELKOM BIJ MAHJONG   |
************************");

            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("druk op een ");

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("willekeurige toets ");

            Console.ResetColor();

            Console.Write("om de steen te tonen...");

            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine();



            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.Write(" ◉◉◉ ");

            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.Write(" ◉◉◉ ");

            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write(" ◉◉◉ ");

            Console.WriteLine();
            Console.WriteLine();

            Console.ResetColor();

            Console.Write("druk op een toets om af te sluiten...");




            Console.ReadKey();
        }
    }
}
