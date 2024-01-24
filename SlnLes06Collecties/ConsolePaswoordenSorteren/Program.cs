using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static void Main()
    {
        string[] paswoorden = { "klepketoe", "test", "Azerty123", "rogier@work", "password", "MisterNasty12", "pwnz0red" };

        List<string> nietOkPaswoorden = new List<string>();
        List<string> okPaswoorden = new List<string>();

        foreach (string paswoord in paswoorden)
        {
            if (IsCorrectPaswoord(paswoord))
            {
                okPaswoorden.Add(paswoord);
            }
            else
            {
                nietOkPaswoorden.Add(paswoord);
            }
        }

        Console.WriteLine("Alle paswoorden:");

        for (int i = 0; i < paswoorden.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {paswoorden[i]}");
        }
        Console.WriteLine();
        Console.WriteLine("Ok: " + string.Join(", ", okPaswoorden));
        Console.WriteLine("Niet ok: " + string.Join(", ", nietOkPaswoorden));

        Console.ReadLine();
    }
    private static bool IsCorrectPaswoord(string paswoord)
    {
        string[] nietToegestaan = { "123456789", "password", "Azerty123" };

        if (paswoord.Length < 8 || paswoord.Contains('@') || nietToegestaan.Contains(paswoord))
        {
            return false;
        }
        return true;
    }
}