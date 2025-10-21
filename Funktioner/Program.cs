//static void PrintName (string firstNamn, string lastNamn )
//{
//    Console.WriteLine(firstNamn + lastNamn);
//}

//string firstNamn = "Kalle ";
//string lastNamn = "Anka";
//PrintName(firstNamn, lastNamn);


// 2.
//using System.Runtime.CompilerServices;

//static string PrintName (string firstNamn, string lastNamn )
//{
//    return firstNamn + lastNamn;
//}

//String firstName = "Kalle ";
//string lastName = "Anka";

//Console.WriteLine(PrintName(firstName, lastName));


// 3.
//static bool Longer (string text, int heltal)
//{
//    if (heltal < text.Length)
//    {
//        return true;
//    }
//    else
//        return false;
//}

//Console.WriteLine(Longer("hallå", 8));


// 4.
//static double VärmeKalk(double celsius)
//{
//    double fahrenheit = (celsius * 1.8) + 32;
//    return fahrenheit;
//}

//Console.WriteLine("*** Celsius till Fahrenheit kalkylator ***");
//Console.WriteLine("Klicka 'enter' för att avsluta.");

//while (true)
//{
//    Console.WriteLine("Mata in Celsius: ");
//    string input = Console.ReadLine();
//    if(string.IsNullOrEmpty(input))
//    {
//        break;
//    }
//    if (Double.TryParse(input, out double celsius))
//    {
//        Console.WriteLine($"{celsius}grader Celsius = {VärmeKalk(celsius)} grader Fahrenheit");
//    }
//    else
//    {
//        Console.WriteLine("Fel: Ogiltigt svar.");
//    }
//}


// 5.
//static string MyJoin(string separator, params string[] text)
//{
//    string result = string.Empty;

//    for (int i = 0; i<text.Length; i++)
//    {
//        result += text[i];

//        if (i < text.Length - 1)
//        {
//            result += separator;
//        }
//    }

//    return result;
//}

//while (true)
//{ 
//    Console.WriteLine("Mata in en separator mellan orden: ");
//    string separat = Console.ReadLine();

//    Console.Write("Mata in flera ord: ");
//    string[] ord = Console.ReadLine().Split(' ');

//    Console.WriteLine(MyJoin(separat, ord));

//    Console.WriteLine("Vill du köra igen? Y/N");
//    string input = Console.ReadLine().ToLower();
//    if(input == "y")
//    {
//        continue;
//    }
//    if(input == "n")
//    {
//        break;
//    }

//}


// 7.
//static double MedelVärde (int[] numbers)
//{
//    double sum = 0;

//    for (int i = 0; i<numbers.Length; i++)
//    {
//        sum += numbers[i];
//    }
//    return sum / numbers.Length;
//}


//int[] numbers = {5, 15, 50, 20};
//double medel = MedelVärde(numbers);

//Console.WriteLine($"Medelvärdet av {String.Join(", ", numbers)} är {medel}");


// 8.

//static string[] NumbersToWord (int heltal)
//{
//    string s = heltal.ToString();
//    string[] textnummer = new string[s.Length];

//    for (int i = 0; i<s.Length; i++)
//    {
//        switch (s[i])
//        { 
//            case '0': textnummer[i] = "noll"; break;
//            case '1': textnummer[i] = "ett"; break;
//            case '2': textnummer[i] = "två"; break;
//            case '3': textnummer[i] = "tre"; break;
//            case '4': textnummer[i] = "fyra"; break;
//            case '5': textnummer[i] = "fem"; break;
//            case '6': textnummer[i] = "sex"; break;
//            case '7': textnummer[i] = "sju"; break;
//            case '8': textnummer[i] = "åtta"; break;
//            case '9': textnummer[i] = "nio"; break;
//        }
//    }

//    return textnummer;
//}

//Console.Write("Mata in ett heltal: ");
//int input = Convert.ToInt32(Console.ReadLine());
//string[] textnummer = NumbersToWord(input);

//Console.WriteLine(string.Join(", ", textnummer));


// 9.
//static string IntegerToText(ushort input)
//{
//    string[] ental = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
//    string[] teen = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
//    string[] shorty = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

//    if (input == 0)
//        return "zero";

//    string output = string.Empty;
//    int remaining = input;

//    if (remaining >= 1000)
//    {
//        int digit = remaining / 1000;
//        output += ental[digit - 1] + " thousand ";
//        remaining %= 1000;
//    }

//    if (remaining >= 100)
//    {
//        int digit = remaining / 100;
//        output += ental[digit - 1] + " hundred ";
//        remaining %= 100;
//    }

//    if (remaining >= 11 && remaining <= 19)
//    {
//        output += teen[remaining - 11];
//    }
//    else
//    {
//        if (remaining >= 10)
//        {
//            int digit = remaining / 10;
//            output += shorty[digit - 1] + " ";
//            remaining %= 10;
//        }

//        if (remaining >= 1 && remaining <= 9)
//        {
//            output += ental[remaining - 1];
//        }
//    }

//    return output.Trim();
//}

//Console.WriteLine("1243 : " +IntegerToText(1243));



// 10.
//static int[] IndexesOf (string text, char c)
//{
//    List<int> indexes = new List<int>();

//	for (int i = 0; i < text.Length; i++)
//	{
//		if (text[i] == c)
//		{
//			indexes.Add(i);
//		}
//	}


//	return indexes.ToArray();
//}

//int[] output = IndexesOf("hello world", 'l');
//Console.WriteLine(string.Join(", ", output));


// 11.
//static int ThrowDice()
//{
//    Random rnd = new Random();
//    return rnd.Next(1, 7);
//}

//Console.WriteLine(ThrowDice());
//static int[] ThrowMultipleDice(int sidor, int n)
//{
//    Random rnd = new Random();
//    int[] kast = new int[n];
//    for (int i = 0; i < n; i++)
//    {
//        kast[i] = rnd.Next(1, sidor + 1);
//    }
//    return kast;
//}

//Console.Write("Ange hur många sidor tärningen ska ha: ");
//int sidor = Convert.ToInt32(Console.ReadLine());
//Console.Write("Ange hur många kast du vill slå: ");
//int n = Convert.ToInt32(Console.ReadLine());

//foreach (var kast in ThrowMultipleDice(sidor, n))
//{
//    Console.WriteLine(kast);
//}


// 12.
//static void DrawBox(int width, int height)
//{
//	for (int i = 0; i < height; i++)
//	{
//		for (int j = 0; j < width; j++)
//		{
//			if (i == 0 || i == height -1 || j == 0 || j == width -1)
//			{
//                Console.Write("#");
//			}
//			else Console.Write("-");
//		}
//        Console.WriteLine();
//    }

//}

//DrawBox(7, 4);




// 13.

//static void DrawBox(int width, int height)
//{
//    for (int i = 0; i < height; i++)
//    {
//        for (int j = 0; j < width; j++)
//        {
//            if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
//            {
//                Console.Write("#");
//            }
//            else Console.Write("-");
//        }
//        Console.WriteLine();
//    }

//}


//int width = 15;
//int height = 8;
//int x = width / 2;
//int y = height / 2;

//DrawBox(width, height);

//void Move(int newX, int newY)
//{
//    Console.SetCursorPosition(x, y);
//    Console.Write('-');
//    x = newX;
//    y = newY;
//    Console.SetCursorPosition(x, y);
//    Console.Write('@');
//}

//Console.SetCursorPosition(x, y);
//Console.Write('@');

//while (true)
//{
//    ConsoleKeyInfo key = Console.ReadKey(true);
//    if (key.Key == ConsoleKey.RightArrow && x < width - 2) Move(x + 1, y);
//    if (key.Key == ConsoleKey.LeftArrow && x > 1) Move(x - 1, y);
//    if (key.Key == ConsoleKey.UpArrow && y > 1) Move(x, y - 1);
//    if (key.Key == ConsoleKey.DownArrow && y < height - 2) Move(x, y + 1);
//}


// 14
using System;
using System.Collections.Generic;
using System.Threading;

int width = 30;
int height = 15;
Random rnd = new Random();
Console.CursorVisible = false;

bool quitGame = false;

while (!quitGame)
{
    // --- initiera spelet ---
    Console.Clear();
    char[,] box = DrawBox(height, width);
    List<(int x, int y)> snake = new List<(int, int)>();
    int snakeLength = 1;

    PrintBox(box);

    // starta ormen i mitten
    int x = width / 2;
    int y = height / 2;
    snake.Add((x, y));
    box[y, x] = '@';
    Console.SetCursorPosition(x, y);
    Console.Write('@');

    // första äpplet
    PlaceApple();

    // starta riktning (höger)
    int dx = 1;
    int dy = 0;

    bool running = true;

    while (running)
    {
        // kolla om en tangent är tryckt
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.RightArrow && dx != -1) { dx = 1; dy = 0; }
            if (key == ConsoleKey.LeftArrow && dx != 1) { dx = -1; dy = 0; }
            if (key == ConsoleKey.UpArrow && dy != 1) { dx = 0; dy = -1; }
            if (key == ConsoleKey.DownArrow && dy != -1) { dx = 0; dy = 1; }
        }

        int newX = snake[0].x + dx;
        int newY = snake[0].y + dy;

        // kolla väggar eller självkrock
        if (box[newY, newX] == '#' || box[newY, newX] == '@')
        {
            running = false;
            break;
        }

        if (box[newY, newX] == 'ä')
        {
            snakeLength++;
            PlaceApple();
        }

        Move(newX, newY);

        Thread.Sleep(200); 
    }

    Console.Clear();
    Console.WriteLine("GAME OVER!");
    Console.WriteLine("Tryck 'R' för att starta om eller 'ESC' för att avsluta.");

    while (true)
    {
        var checkKey = Console.ReadKey(true).Key;
        if (checkKey == ConsoleKey.Escape) { quitGame = true; break; }
        if (checkKey == ConsoleKey.R) { break; }
    }

    void PlaceApple()
    {
        int rx, ry;
        do
        {
            rx = rnd.Next(1, width - 1);
            ry = rnd.Next(1, height - 1);
        } while (box[ry, rx] != ' ');

        box[ry, rx] = 'ä';
        Console.SetCursorPosition(rx, ry);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write('ä');
        Console.ResetColor();
    }

    void Move(int newX, int newY)
    {
        // lägg in nytt huvud
        snake.Insert(0, (newX, newY));
        box[newY, newX] = '@';
        Console.SetCursorPosition(newX, newY);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write('@');
        Console.ResetColor();

        // om ormen är för lång -> ta bort svansen
        if (snake.Count > snakeLength)
        {
            var tail = snake[^1];
            box[tail.y, tail.x] = ' ';
            Console.SetCursorPosition(tail.x, tail.y);
            Console.Write(' ');
            snake.RemoveAt(snake.Count - 1);
        }
    }
}

static char[,] DrawBox(int height, int width)
{
    char[,] display = new char[height, width];

    for (int y = 0; y < height; y++)
    {
        for (int x = 0; x < width; x++)
        {
            if (y == 0 || y == height - 1 || x == 0 || x == width - 1)
                display[y, x] = '#';
            else
                display[y, x] = ' ';
        }
    }
    return display;
}

static void PrintBox(char[,] display)
{
    for (int y = 0; y < display.GetLength(0); y++)
    {
        for (int x = 0; x < display.GetLength(1); x++)
        {
            Console.Write(display[y, x]);
        }
        Console.WriteLine();
    }
}