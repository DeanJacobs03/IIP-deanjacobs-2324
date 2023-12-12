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

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine(@"WELKOM IN HET BUFFETRESTAURANT
==============================");

            Console.WriteLine();

            Console.WriteLine("Alles is à volonté en dranken zijn inbegrepen!");
            Console.WriteLine("!!Promotie!! Vandaag ronden we het totaalbedrag af naar beneden!");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;


            Console.Write("Aantal seizoensbuffets (€18.5): ");
            int SeizoensBuffet = Convert.ToInt32(Console.ReadLine());

            Console.Write("Aantal dessertenbuffets (€7.95): ");
            int DessertenBuffet = Convert.ToInt32(Console.ReadLine());

            Console.Write("Aantal kids menus (€8.95): ");
            int KidsMenus = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Fooi (0 indien geen): ");
            double Fooi = Convert.ToDouble(Console.ReadLine());

            double Totaal = (SeizoensBuffet * 18.50) + (DessertenBuffet * 7.95) + (KidsMenus + 8.95) + Fooi;
            Console.WriteLine($"Totaal te betalen: €{Totaal}");


            int Afgerond = (int)Math.Floor(Totaal);
            Console.WriteLine($"Totaal te betalen: €{Afgerond}");


            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Cash betaald: ");
            int betaald = Convert.ToInt32(Console.ReadLine());

            

            int vijftig = (betaald - Afgerond) / 50;
            int rest1 = (betaald - Afgerond) - vijftig;

            int twintig = rest1 / 20;
            int rest2 = rest1 - (twintig * 20);

            int tien = rest2 / 10;
            int rest3 = rest2 - (tien * 10);

            int vijf = rest3 / 5;
            int rest4 = rest3 - (vijf * 5);

            int twee = rest4 / 2;
            int rest5 = rest4 - (twee * 2);

            int een = rest5 / 1;
            int rest6 = rest5 - (een * 1);


            Console.WriteLine("U krijgt terug: ");

            Console.WriteLine($"- {vijftig} briefje(s) van 50");
            Console.WriteLine($"- {twintig} briefje(s) van 20");
            Console.WriteLine($"- {tien} briefje(s) van 10");
            Console.WriteLine($"- {vijf} briefje(s) van 5");
            Console.WriteLine($"- {twee} briefje(s) van 2");
            Console.WriteLine($"- {een} briefje(s) van 1");

            Console.ReadKey();
        }
    }
}
