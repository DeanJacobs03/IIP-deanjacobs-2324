using System;
using System.Text;

namespace typprogramma
{
    internal class Program
    {
        private static string[] EnglishSentences = { "Arrived compass prepare an on as.", "Man request adapted spirits set pressed. Up to denoting subjects sensible feelings it indulged directly. We dwelling elegance do shutters appetite yourself diverted. Our next drew much you with rank. Tore many held age hold rose than our. She literature sentiments any contrasted. Set aware joy sense young now tears china shy." };
        private static string[] DutchWords = { "Hallo", "brood" };
        private static string[] FrenchWords = { "skip", "imminent" };
        private static Random Rnd = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Kies een taal:");
            Console.WriteLine("1 Engels");
            Console.WriteLine("2 Nederlands");
            Console.WriteLine("3 Frans");

            string UserInput = Console.ReadLine();
            int Keuze;

            if (int.TryParse(UserInput, out Keuze))
            {
                switch (Keuze)
                {
                    case 1:
                        PrintSentences(EnglishSentences);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default :
                        break;
                }
            }
            Environment.Exit(0);
           
        }

        private static void PrintSentences(string[] Sentences)
        {
            int Index = Rnd.Next(0, Sentences.Length);
            string Sentence = Sentences[Index];
            StringBuilder Sb = new StringBuilder();
            char Character;
            do
            {
                Console.Clear();
                Console.WriteLine(Sentence);
                Console.WriteLine();
                Console.Write(Sb.ToString());
                ConsoleKeyInfo ConsoleKeyInfo = Console.ReadKey(false);
                Character = ConsoleKeyInfo.KeyChar;
                if (Character != (char)8){
                    Sb.Append(Character);
                }
                else
                {
                    Sb.Remove(Sb.Length -1, 1);
                }
                
            } while (!Sb.ToString().Equals(Sentence) && Character != (char)27); 
            
        }
    }
}
