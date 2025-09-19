//  1.
//Console.Write("Skriv ditt namn: ");
//string namn = Console.ReadLine();
//Console.WriteLine($"Hej {namn}!");


//2.
//Console.Write("Skriv in första talet: ");
//int num1 = Int32.Parse(Console.ReadLine());

//Console.Write("Skriv in andra talet: ");
//int num2 = Int32.Parse(Console.ReadLine());
//int sum = num1 * num2;
//Console.WriteLine($"{num1} * {num2} = {sum}");

//Console.Write("Skriv in första talet: ");
//if (int.TryParse(Console.ReadLine(), out int num1))
//{
//    Console.Write("Skriv in andra talet: ");
//    if (int.TryParse(Console.ReadLine(), out int num2))
//    {
//        Console.WriteLine($"{num1} * {num1 * num2}");
//    }
//}
//else
//{
//    Console.WriteLine("Fel: Första talet var inte ett heltal.");
//}


//3.
//string password = "Svardfisk";
//Console.Write("Lösenord: ");
//string tryPass = Console.ReadLine();
//Console.WriteLine(tryPass == password ? "Rätt lösenord!" : "Fel lösenord!");

//4.
//Console.Write("Skriv ett tal: ");
//if (int.TryParse(Console.ReadLine(), out int num1))
//{
//    if (num1 == 100)
//    {
//        Console.WriteLine("Ditt tal är 100");
//    }
//    else if (num1 < 100)
//    {
//        Console.WriteLine("Ditt tal är mindre än 100");
//    }
//    else
//    {
//        Console.WriteLine("Ditt tal är större än 100");
//    }
//}
//else
//{
//    Console.WriteLine("Fel: talet är inte ett heltal");
//}


//5.
//Console.Write("Skriv in ett tal: ");
//if (double.TryParse(Console.ReadLine(), out double tal))
//{
//    Console.WriteLine($"{tal} är dubbelt så mycket som {tal / 2}");
//    Console.WriteLine($"{tal} är hälften så mycket som {tal * 2}");
//}
//else Console.WriteLine("Fel: Du skrev inte in ett tal..");


//6.
//Console.Write("Första talet: ");
//double talEtt = double.Parse(Console.ReadLine());

//Console.Write("Välj +, -, *, /: ");
//string tecken = Console.ReadLine();

//Console.Write("Andra talet: ");
//double talTvå = double.Parse(Console.ReadLine());

//switch (tecken)
//{
//    case "+":
//        Console.WriteLine($"{talEtt} + {talTvå} = {talEtt + talTvå}");
//        break;
//    case "-":
//        Console.WriteLine($"{talEtt} - {talTvå} = {talEtt - talTvå}");
//        break;
//    case "*":
//        Console.WriteLine($"{talEtt} * {talTvå} = {talEtt * talTvå}");
//        break;
//    case "/":
//        Console.WriteLine($"{talEtt} / {talTvå} = {talEtt / talTvå}");
//        break;
//    default:
//        Console.WriteLine("Fel tecken.");
//        break;
//}


//7.
//double summa = 0;
//int antal = 0;
//Console.Write("Skriv in ett tal: ");

//while (double.TryParse(Console.ReadLine(), out double tal))
//{
//    summa += tal;
//    antal++;
//    Console.WriteLine(summa);
//    Console.Write("Skriv in ett tal: ");
//}

//double medel = summa / antal;
//Console.WriteLine($"Medelvärde: {medel}");



//// loops ///////


//1.
//int i = 20;
//while (i <= 30)
//{
//    Console.WriteLine(i);
//    i++;
//}


//2.
//int i = 0;
//while (i <= 30)
//{
//    Console.WriteLine(i);
//    i++;
//    i++;
//}


//3.
//int i = 0;
//while (i <= 30)
//{
//    if (i % 3 == 0 && i != 0)
//    {
//        Console.WriteLine("Hej");
//    }
//    else
//    {
//        Console.WriteLine(i);
//    }
//    i++;
//}


//4.


//int i = 1;
//while (true)
//{
//    Console.Write("Skriv in ett tal: ");
//    if (double.TryParse(Console.ReadLine(), out double num1))
//    {
//        while (i <= 10)
//        {
//            Console.WriteLine($"{i} * {num1} = {i * num1}");
//            i++;
//        }
//        break;
//    }
//    else Console.WriteLine("Du skrev inte in ett tal..");
//}

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{i} * {num1} = {i * num1}");
//}


//5.
//int i = 0;
//int sum = 0;
//while (i <= 1000)
//{
//    sum += i;
//    i++;


//}
//Console.WriteLine(sum);


//6.
//int i = 1;
//BigInteger sum = 1;

//while (i <= 64)
//{


//    Console.WriteLine($"Ruta {i}: {sum}");
//    sum *= 2;
//    i++;
//}


//7.
//Console.Write("Mata in höjd: ");
//int höjd = Int32.Parse(Console.ReadLine());
//Console.Write("Mata in bredd: ");
//int bredd = Int32.Parse(Console.ReadLine());
//int i = 0;
//int j = 0;
//string xBredd = string.Empty;

//while (j < bredd)
//{
//    xBredd += "X";
//    j++;
//}

//while (i < höjd)
//{

//    Console.WriteLine(xBredd);
//    i++;
//}


//8.
//Console.Write("Mata in höjd: ");
//int höjd = Int32.Parse(Console.ReadLine());
//Console.Write("Mata in bredd: ");
//int bredd = Int32.Parse(Console.ReadLine());
//int i = 0;
//int j = 0;
//string xBredd = string.Empty;

//while (j < bredd)
//{
//    if (j % 2 == 0)
//    {
//        xBredd += "X";
//    }
//    else
//    {
//        xBredd += "O";
//    }
//    j++;

//}

//while (i < höjd)
//{

//    Console.WriteLine(xBredd);
//    i++;
//}


//9.
//Console.Write("Mata in höjd: ");
//int höjd = Int32.Parse(Console.ReadLine());
//Console.Write("Mata in bredd: ");
//int bredd = Int32.Parse(Console.ReadLine());
//int i = 0;
//int j = 0;
//int y = 0;
//string xBredd = string.Empty;
//string oBredd = string.Empty;

//while (j < bredd)
//{
//    if (j % 2 == 0)
//    {
//        xBredd += "X";
//    }
//    else
//    {
//        xBredd += "O";
//    }
//    j++;

//}
//while (y < bredd)
//{
//    if (y % 2 == 0)
//    {
//        oBredd += "O";
//    }
//    else
//    {
//        oBredd += "X";
//    }
//    y++;

//}

//while (i < höjd)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(xBredd);
//    }
//    else
//    {
//        Console.WriteLine(oBredd);
//    }

//    i++;
//}


//10.
//Console.WriteLine("Mata in höjd: ");
//int height = Int32.Parse(Console.ReadLine());

//Console.WriteLine("Mata in bredd: ");
//int width = Int32.Parse(Console.ReadLine());

//for (int i = 1; i <= height; i++)   
//{
//    for (int j = 1; j <= width; j++)   
//    {
//        if (i == 1 || i == height || j == 1 || j == width)
//        {
//            Console.Write("X");
//        }
//        else
//        {
//            Console.Write(" ");
//        }
//    }
//    Console.WriteLine(); 
//}

//  11.
//string addNumber = string.Empty;

//for (int i = 1; i <= 9; i++)
//{
//    addNumber += i.ToString();
//    Console.WriteLine(addNumber);
//}


// 12.

//for (int i = 1; i <= 9; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        string rad = string.Empty;
//        for (int k = 1; k <= j; k++)
//        {
//            rad += k;
//        }
//        Console.WriteLine(rad);
//    }
//    Console.WriteLine();
//}


//  13.
//for (int i = 2; i <= 100; i++)
//{
//    bool isPrime = true;

//    for (int j = 2; j <= Math.Sqrt(i); j++)
//    {
//        if (i % j == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }

//    if (isPrime)
//    {
//        Console.WriteLine(i);
//    }
//}


// 14.
//Random rnd= new Random();
//int answer = rnd.Next(1, 101);

//Console.Write("Gissa ett tal mellan 1-100: ");

//while(true)
//{
//    bool isNumber = int.TryParse(Console.ReadLine(), out int guess);
//    if (!isNumber)
//    {
//        Console.WriteLine("Ogiltig inmatning, skriv ett heltal!");
//        continue;
//    }

//    if (guess < answer) Console.WriteLine("För lågt. Gissa igen: ");

//    else if (guess > answer) Console.WriteLine("För högt. Gissa igen: ");

//    else
//    {
//     Console.WriteLine("Rätt!");
//     break;
//    }
//}

//Random rnd = new Random();
//int answer = rnd.Next(1, 101);

//int low = 1;
//int high = 100;
//Console.Write("Gissa 1-100: ");

//while (true)
//{
//    int guess = (low + high) / 2;
//    Console.WriteLine($"Datorn gissar: {guess}");
//    if (guess < answer)
//    {
//        Console.Write("För lågt. ");
//        low = guess + 1;
//    }

//    else if (guess > answer)
//    {
//        Console.Write("För högt. ");
//        high = guess - 1;
//    }

//    else
//    {
//        Console.WriteLine("Rätt!");
//        break;
//    }
//}


//  15.
//Random rnd = new Random();
//int aiPoints = 0;
//int points = 0;

//Console.WriteLine("STEN SAX PÅSE!? Först till 5 Poäng! \nSkriv \"avsluta\" för att sluta");

//while (true)
//{
//    string userGuess = Console.ReadLine().ToLower();

//    if (userGuess == "avsluta" && points>aiPoints)
//    {
//        Console.WriteLine($"Du vann! Du fick {points} poäng, Dator: {aiPoints} poäng");
//        break;
//    }
//    else if (userGuess == "avsluta" && points<aiPoints)
//    {
//        Console.WriteLine($"Datorn vann! Du fick: {points} poäng, Dator: {aiPoints} poäng");
//        break;
//    }
//    else if (userGuess == "avsluta" && points==aiPoints)
//    {
//        Console.WriteLine($"Oavgjort! Du fick: {points} poäng, Dator: {aiPoints} poäng");
//        break;
//    }

//    int aiIntGuess = rnd.Next(1, 4);
//    string aiGuess = string.Empty;

//    if (aiIntGuess == 1) aiGuess = "Sten";
//    if (aiIntGuess == 2) aiGuess = "Sax";
//    if (aiIntGuess == 3) aiGuess = "Påse";


//    if (userGuess == "sten")
//    {
//        if (aiGuess == "Sten") Console.WriteLine("Sten mot Sten. Oavgjort!");
//        else if (aiGuess == "Sax") { Console.WriteLine("Sten mot Sax. +1 Poäng till dig!"); points++; }
//        else if (aiGuess == "Påse") { Console.WriteLine("Sten mot Påse. +1 Poäng till datorn!"); aiPoints++; }
//    }
//    else if (userGuess == "sax")
//    {
//        if (aiGuess == "Sten") { Console.WriteLine("Sax mot Sten. +1 Poäng till datorn!"); aiPoints++; }
//        else if (aiGuess == "Sax") Console.WriteLine("Sax mot Sax. Oavgjort!");
//        else if (aiGuess == "Påse") { Console.WriteLine("Sax mot Påse. +1 Poäng till dig!"); points++; }
//    }
//    else if (userGuess == "påse")
//    {
//        if (aiGuess == "Sten") { Console.WriteLine("Påse mot Sten. +1 Poäng till dig!"); points++; }
//        else if (aiGuess == "Sax") { Console.WriteLine("Påse mot Sax. +1 Poäng till datorn!"); aiPoints++; }
//        else if (aiGuess == "Påse") Console.WriteLine("Påse mot Påse. Oavgjort!");
//    }
//    else
//    {
//        Console.WriteLine("Ogiltigt val, skriv sten, sax eller påse.");
//    }
//    if (points == 5)
//    {
//        Console.WriteLine($"Du vann! Du fick {points} poäng, Dator: {aiPoints} poäng");
//        break;
//    }
//    else if (aiPoints == 5)
//    {
//        Console.WriteLine($"Datorn vann! Du fick {points} poäng, Dator: {aiPoints} poäng");
//        break;
//    }
//}