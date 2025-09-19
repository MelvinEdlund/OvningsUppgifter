////  1.
//Console.Write("Skriv något: ");
//string något = Console.ReadLine();
//for (int i = 0; i < något.Length; i++)
//{
//    Console.WriteLine(något[i]);
//}


////  2.
//string[] numString = { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };
//Console.Write("Mata in en siffra: ");
//int num = Int32.Parse(Console.ReadLine());

//Console.WriteLine(numString[num]);


////  3.
//Console.Write("Skriv något: ");
//string något = Console.ReadLine();

//for (int i = något.Length - 1; i >= 0; i--)
//{
//    Console.Write(något[i]);
//}


//  4.
//Console.Write("Skriv något: ");
//string något = Console.ReadLine();

//char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö',
//                  'A', 'E', 'I', 'O', 'U', 'Y', 'Å', 'Ä', 'Ö'};
//string resultat = string.Empty;
//foreach (char letter in något)
//{
//    if (vowels.Contains(letter))
//        resultat += '*';
//    else
//        resultat += letter;
//}
//Console.WriteLine(resultat);


//  5.
//Console.Write("klicka enter för att avsluta\nSkriv ett ord: ");

//while (true)
//{
//    string ord = Console.ReadLine().ToLower();
//    string palindrom = string.Empty;
//    if (string.IsNullOrEmpty(ord))
//        break;
//    for (int i = ord.Length-1; i>= 0; i--)
//    {
//         palindrom += ord[i];
//    }
//    if (ord == palindrom)
//    {
//        Console.WriteLine($"{palindrom} är ett palindrom.");
//    }
//    else
//    {
//        Console.WriteLine($"{ord} är inte ett palindrom.");
//    }
//}


//  6. 
//Console.WriteLine("Vad vill du räkna ut?    Skriv ex \"5 * 2\" ");
//string inmatning = Console.ReadLine();
//inmatning = inmatning.Replace(" ", "");

//char[] operats = { '+', '-', '*', '/' };
//char operat = '.';

//foreach (char c in inmatning)
//{
//    if (operats.Contains(c))
//    {
//        operat = c;
//        break;
//    }
//}
//string[] delad = inmatning.Split(operat);
//double num1 = double.Parse(delad[0]);
//double num2 = double.Parse(delad[1]);

//double resultat = 0;

//switch (operat)
//{
//    case '+':
//        resultat = num1 + num2;
//        break;
//    case '-':
//        resultat = num1 - num2;
//        break;
//    case '*':
//        resultat = num1 * num2;
//        break;
//    case '/':
//        resultat = num1 / num2;
//        break;
//}

//Console.WriteLine($"{num1} {operat} {num2} = {resultat}");


//  7.
//string[] ord = new string[7];
//for (int i = 0; i < 7; i++)
//{
//    Console.Write($"Skriv in ett ord {i + 1}: ");
//    ord[i] = Console.ReadLine();
//}
//for (int i = ord.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(ord[i]);
//}


//  8.
//string[] ord = new string[10];
//int count = 0;

//while (true)
//{
//    Console.Write("Skriv in ett ord: ");
//    string input = Console.ReadLine();

//    if (count < 10)
//    {
//        ord[count] = input;
//    }
//    else
//    {
//        for (int i = 0; i < 9; i++)
//        {
//            ord[i] = ord[i + 1];
//        }
//        ord[9] = input;
//    }
//    count++;

//    if (count >= 10)
//    {
//        Console.WriteLine($"ordet för 10 inmatningar sedan var: {ord[0]}");
//    }
//    else
//    {
//        Console.WriteLine("Du har inte skrivit in 10 inmatingar än..");
//    }
//}


// 9.
//string helloWorld = "Hello World";
//string output = string.Empty;
//foreach (char letter in helloWorld)
//{
//    output += letter;
//    Console.WriteLine(output);
//}



//// 10.
//Console.Write("Mata in en text: ");
//string textInput = Console.ReadLine();

//Console.Write("Mata in en bokstav: ");
//string bokstav = Console.ReadLine();
//char bokstavCha = Convert.ToChar(bokstav);

//foreach (char letter in textInput)
//{
//    if (letter == bokstavCha)
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.Write(letter);
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Gray;
//        Console.Write(letter);
//    }
//}
//Console.ForegroundColor = ConsoleColor.Gray;


// 11.
//Console.Write("Mata in en text: ");
//string text = Console.ReadLine();

//Console.Write("Välj startindex: ");
//int startIndex = Convert.ToInt32(Console.ReadLine());

//Console.Write("Välj stopindex: ");
//int stopIndex = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < text.Length; i++)
//{
//    if (i >= startIndex-1 && i <= stopIndex)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;

//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Gray;
//    }
//    Console.Write(text[i]);
//}


//  12.
//Console.Write("Mata in en text: ");
//string input = Console.ReadLine();

//Console.Write("Mata in en bokstav: ");
//char bokstav = Convert.ToChar(Console.ReadLine());
//bool isRed = false;

//foreach  (char letter in input)
//{
//    if(bokstav == letter) isRed = !isRed;

//    if (isRed)
//        Console.ForegroundColor = ConsoleColor.Red;
//    else
//        Console.ForegroundColor = ConsoleColor.Gray;

//    Console.Write(letter);
//}