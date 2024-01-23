using System;

namespace typprogramma
{
    internal class Program
    {
        private static string[] englishsentences = { "Arrived compass prepare an on as.", "Man request adapted spirits set pressed. Up to denoting subjects sensible feelings it indulged directly. We dwelling elegance do shutters appetite yourself diverted. Our next drew much you with rank. Tore many held age hold rose than our. She literature sentiments any contrasted. Set aware joy sense young now tears china shy." };
        private static string[] dutchsentences = { "Sedert jaren vraag ik mij af, waartoe zulke dingen dienen, en ik sta verbaasd over de onbeschaamdheid, waarmee een dichter of romanverteller u iets op de mouw durft spelden, dat nooit gebeurd is, en meestal niet gebeuren kan.", "Dat zijn ook makelaars in koffie, doch hun adres behoeft ge niet te weten. Ik pas er dus wel op, dat ik geen romans schrijf, of andere valse opgaven doe. Ik heb dan ook altijd opgemerkt dat mensen die zich met zoiets inlaten, gewoonlijk slecht wegkomen. Ik ben drieënveertig jaar oud, bezoek sedert twintig jaren de beurs, en kan dus voor de dag treden, als men iemand roept die ondervinding heeft." };
        private static string[] frenchsentences = { "Le client est très important merci, le client sera suivi par le client. Énée n'a pas de justice, pas de résultat, pas de ligula, et la vallée veut la sauce. Morbi mais qui veut vendre une couche de contenu triste d'internet. Être ivre maintenant, mais ne pas être ivre maintenant, mon urne est d'une grande beauté, mais elle n'est pas aussi bien faite que dans un livre.", "Mécène dans la vallée de l'orc, dans l'élément même. Certaines des exigences faciles du budget, qu'il soit beaucoup de temps pour dignissim et. Je ne m'en fais pas chez moi, ça va être moche dans le vestibule. Mais aussi des protéines de Pour avant la fin de la semaine, qui connaît le poison, le résultat." };
        private static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Kies een taal:");
            Console.WriteLine("1 Engels");
            Console.WriteLine("2 Nederlands");
            Console.WriteLine("3 Frans");

            string userinput = Console.ReadLine();

            switch (userinput) //break niet toegestaan return default wel
            {
                case "1":
                    PrintSentences(englishsentences);
                    break;
                case "2":
                    PrintSentences(dutchsentences);
                    break;
                case "3":
                    PrintSentences(frenchsentences);
                    break;
                default:
                    break;
            }

            Environment.Exit(0);

        }

        private static void PrintSentences(string[] sentences)
        {
            int index = rnd.Next(0, sentences.Length);
            string sentence = sentences[index];
            {
                string getypteTekst = "";

                bool escape = false;

                Console.WriteLine(sentence);
                //gaat door zolang je nog niet alles getypt hebt
                do
                {
                    //typen 
                    ConsoleKeyInfo ck = Console.ReadKey();
                    if (ck.Key == ConsoleKey.Escape)
                    {
                        escape = true;
                    }
                    else
                    {
                        char letter = ck.KeyChar;
                        getypteTekst += letter;

                        Console.Clear();
                        // dit gaat tekst opnieuw tonen met kleur
                        for (int i = 0; i < sentence.Length; i++)
                        {
                            if (getypteTekst.Length < i + 1)
                            {
                                Console.ForegroundColor = ConsoleColor.White;

                            }
                            else if (sentence[i] == getypteTekst[i])
                            {
                                Console.ForegroundColor = ConsoleColor.Green;

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            Console.Write(sentence[i]);
                        }
                    }



                }
                while (sentence.Length > getypteTekst.Length && !escape);
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("ggestopt met typen"); //bug "g" fix

                Console.ReadKey();
            }
        }
    }

}
