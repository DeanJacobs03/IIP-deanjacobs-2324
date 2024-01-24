using System;
using System.Collections.Generic;

namespace ConsoleBergbeklimmen
{
    internal class Program
    {
        private static int[] InlezenHoogtes()
        {
            List<int> list = new List<int>();
            int hoogte;

            do
            {
                Console.Write("Voer een hoogtemeting in (in m): ");
                hoogte = Convert.ToInt32(Console.ReadLine());
                if (hoogte != 0)
                {
                    list.Add(hoogte);
                }
            }
            while (hoogte != 0);

            return list.ToArray();
        }
        private static int[] BerekenStijgingen(int[] hoogtes)
        {
            if (hoogtes.Length < 2)
            {
                return new int[0];
            }

            int[] stijgingen = new int[hoogtes.Length - 1];

            for (int i = 1; i < hoogtes.Length; i++)
            {
                int verschilHoogtes = hoogtes[i] - hoogtes[i - 1];
                stijgingen[i - 1] = verschilHoogtes;
            }

            return stijgingen;
        }

        private static int BerekenTotaleStijging(int[] hoogtes)
        {
            if (hoogtes.Length < 2)
            {
                return 0;
            }

            int totaleStijging = 0;

            for (int i = 1; i < hoogtes.Length; i++)
            {
                int hoogteVerschil = hoogtes[i] - hoogtes[i - 1];

                if (hoogteVerschil > 0)
                {
                    totaleStijging += hoogteVerschil;
                }
            }

            return totaleStijging;
        }
        private static int BerekenSterksteStijging(int[] hoogtes)
        {
            if (hoogtes.Length < 2)
            {
                return 0;
            }
            int sterksteStijging = 0;

            for (int i = 1; i < hoogtes.Length; i++)
            {
                int hoogteVerschil = hoogtes[i] - hoogtes[i - 1];

                if (hoogteVerschil > sterksteStijging)
                {
                    sterksteStijging = hoogteVerschil;
                }
            }

            return sterksteStijging;
        }
        private static void Main(string[] args)
        {
            int[] list = InlezenHoogtes();
            int[] stijgingen = BerekenStijgingen(list);

            Console.Write("Stijging: ");

            for (int i = 0; i < stijgingen.Length; i++)
            {
                Console.Write(stijgingen[i]);

                if (i < stijgingen.Length - 1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.Write(" meter");
                }
            }

            Console.WriteLine();

            int totaleStijging = BerekenTotaleStijging(list);
            int sterksteStijging = BerekenSterksteStijging(list);

            Console.WriteLine();
            Console.WriteLine($"De hoogste helling is {sterksteStijging} meter");
            Console.WriteLine($"De totale stijging is {totaleStijging} meter");

            Console.ReadKey();
        }
    }
}
