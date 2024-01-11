using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKlinkersSpaties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een tekst: ");

            string input = Console.ReadLine();

            int klinkers = 0;

            int spaties = 0;


            foreach (char c in input)
            {

                if (char.IsLetter(c))
                {

                    klinkers++;

                }
                else if (char.IsWhiteSpace(c))
                {

                    spaties++;

                }

            }


            Console.WriteLine("Deze tekst bevat " + klinkers + " klinkers en " + spaties + " spaties");


            string geheimschrift = "";


            foreach (char c in input)
            {

                if (char.IsLetter(c))
                {

                    int code = (int)c;

                    if (char.IsLower(c))
                    {

                        code = ((code - 97) + 1) % 26 + 97;

                    }
                    else
                    {

                        code = ((code - 65) + 1) % 26 + 65;

                    }

                    geheimschrift += (char)code;

                }
                else
                {

                    geheimschrift += c;

                }

            }


            Console.WriteLine("In geheimschrift: " + geheimschrift);
            Console.ReadKey();
        }

    }
}
    