using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        const string secret = "penis"; // målordet
        const int maxAttempts = 6;
        int attempts = 0;
        bool won = false;

        Console.WriteLine("Wordle (konsol) — gissa ett 5-bokstäversord. Du har 6 försök.");
        Console.WriteLine("Grönt = rätt plats, Gult = finns i ordet, Grått = finns inte.\n");

        while (attempts < maxAttempts && !won)
        {
            attempts++;
            string guess;

            // Läs och validera gissning
            while (true)
            {
                Console.Write($"Försök {attempts}/{maxAttempts}: ");
                guess = Console.ReadLine()?.Trim().ToLower() ?? "";
                if (guess.Length != 5)
                {
                    Console.WriteLine("Skriv ett ord med exakt 5 bokstäver.");
                    continue;
                }
                bool lettersOnly = true;
                foreach (char c in guess) if (!char.IsLetter(c)) { lettersOnly = false; break; }
                if (!lettersOnly)
                {
                    Console.WriteLine("Endast bokstäver tillåtna.");
                    continue;
                }
                break;
            }

            // Markeringar: 2 = correct, 1 = present, 0 = absent
            int[] status = new int[5];
            char[] secretChars = secret.ToCharArray();
            char[] guessChars = guess.ToCharArray();

            // Räkna frekvens av icke-gröna bokstäver i secret
            var freq = new Dictionary<char, int>();
            for (int i = 0; i < 5; i++)
            {
                if (guessChars[i] == secretChars[i])
                {
                    status[i] = 2; // korrekt plats
                }
                else
                {
                    if (!freq.ContainsKey(secretChars[i])) freq[secretChars[i]] = 0;
                    freq[secretChars[i]]++;
                }
            }

            // Andra pass: hitta närvarande men fel plats (gula)
            for (int i = 0; i < 5; i++)
            {
                if (status[i] == 0)
                {
                    char g = guessChars[i];
                    if (freq.ContainsKey(g) && freq[g] > 0)
                    {
                        status[i] = 1; // finns men fel plats
                        freq[g]--;
                    }
                }
            }

            // Skriv ut gissningen med färger
            for (int i = 0; i < 5; i++)
            {
                switch (status[i])
                {
                    case 2:
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 1:
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
                Console.Write($" {char.ToUpper(guessChars[i])} ");
                Console.ResetColor();
                Console.Write(" ");
            }
            Console.WriteLine("\n");

            // Vinst?
            won = true;
            for (int i = 0; i < 5; i++)
            {
                if (status[i] != 2) { won = false; break; }
            }

            if (won)
            {
                Console.WriteLine($"Grattis! Du gissade ordet på {attempts} försök.");
                break;
            }
        }

        if (!won)
        {
            Console.WriteLine($"Tyvärr — du klarade det inte. Ordet var: {secret.ToUpper()}");
        }

        Console.WriteLine("Tryck valfri tangent för att avsluta...");
        Console.ReadKey(true);
    }
}
