using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankAutomaat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int beginsaldo = 500;

            int keuze;


            do

            {

                Console.WriteLine("Bankautomaat");

                Console.WriteLine("1. Afhaling");

                Console.WriteLine("2. Storting");

                Console.WriteLine("3. Stoppen");

                Console.Write("Je keuze: ");

                string userInput = Console.ReadLine();


                if (int.TryParse(userInput, out keuze))

                {

                    switch (keuze)

                    {

                        case 1:

                            {

                                Console.Write("Welk bedrag wil je afhalen: ");

                                int bedrag = Convert.ToInt32(Console.ReadLine());

                                beginsaldo -= bedrag;

                                Console.WriteLine("Afhaling ok het nieuw saldo is " + beginsaldo);

                                break;

                            }

                        case 2:

                            {

                                Console.Write("Welk bedrag wil je storten: ");

                                int bedrag = Convert.ToInt32(Console.ReadLine());

                                beginsaldo += bedrag;

                                Console.WriteLine("Storting ok het nieuw saldo is " + beginsaldo);

                                break;

                            }

                        case 3:

                            {

                                Console.WriteLine("Bedankt en tot ziens.");

                                break;

                            }

                        default:

                            {

                                Console.WriteLine("Ongeldige keuze");

                                break;

                            }

                    }

                }

                else

                {

                    Console.WriteLine("Ongeldige invoer");

                }

            } while (keuze != 3);

        }
    }
}

    
