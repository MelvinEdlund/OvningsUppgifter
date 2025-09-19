// 1.

//string hej = "Hello World!";

//foreach (char c in hej)
//{
//    string check = Convert.ToString(c);
//    if(check == " ")
//    {
//        break;
//    }
//    Console.Write(c);

//}


// 2.
//string text = "This is just some other text";

//foreach (char c in text)
//{
//    string check = Convert.ToString(c);
//    if(check == " ")
//    {
//        Console.WriteLine();
//        continue;
//    }
//    Console.Write(c);
//}


// 3.
//string text = "Detta är uppgift 3";

//for (int i = 0; i <= text.Length; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.Write("*");
//    }
//    else
//    {
//        Console.Write(text[i]);
//    }
//}


// 4.
//string hej = "Hello world!";

//foreach(char c in hej)

//{

//    if (c == 'o')
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.Write(c);
//    }
//    else if (c == 'l')
//        {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.Write(c);
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Gray;
//        Console.Write(c);
//    }
//}


// 5.
//string hej = "Hello world!!  h e ed eelrwa ll o";

//for (int i = 0; i < hej.Length; i++)
//{
//    Console.ForegroundColor = ConsoleColor.Gray;

//    if (i < hej.Length - 1 && hej[i] == hej[i + 1])
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.Write(hej[i]);
//        i++;
//        Console.Write(hej[i]);
//    }
//    else
//    {
//        Console.Write(hej[i]);
//    }

//}


// 6.
//string wood = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";

//string o = "oo";

//for (int i = 0; i < wood.Length; i++)
//{
//    Console.ForegroundColor = ConsoleColor.Gray;

//    if (i < wood.Length -1 && wood[i] == o[0] && wood [i+1]== o[1])
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.Write(wood[i]);
//        i++;
//        Console.Write(wood[i]);
//    }
//    else
//        Console.Write(wood[i]);



//}


// 7.


//string wood = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
//string chuck = "chuck";

//for (int i = 0; i < wood.Length; i++)
//{
//    Console.ForegroundColor = ConsoleColor.Gray;
//    if (i < wood.Length - chuck.Length && wood.Substring(i, chuck.Length) == chuck)
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.Write(wood.Substring(i, chuck.Length));
//        i += chuck.Length - 1;
//    }
//    else
//        Console.Write(wood[i]);


//}


// 8.
//string wood = "Hoow much wood would a woodchuck chuck if a woodchuck could chuck wood?";
//Console.WriteLine(wood);

//Console.Write("Skriv den text du vill markera grön: ");
//string grön = Console.ReadLine();

//for (int i = 0; i < wood.Length; i++)

//{
//    Console.ForegroundColor = ConsoleColor.Gray;

//    if (i < wood.Length - grön.Length && wood.Substring(i, grön.Length) == grön)
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.Write(wood.Substring(i, grön.Length));
//        i += grön.Length-1;
//    }
//    else
//        Console.Write(wood[i]);
//}


// 9.
//string hello = "Hello world!";

//for (int i = 0; i < hello.Length; i++)
//{
//    for (int j = 0; j <= i; j++)
//    {
//        Console.Write(hello[i]);

//    }

//    Console.WriteLine();
//}


// 10.
//string wood = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";

//string[] splits = wood.Split(' ');

//for (int i = 0; i < splits.Length; i++)
//{
//	for (int j = 0; j <= i; j++)
//	{
//		Console.Write(splits[i] + " ");
//	}
//	Console.WriteLine();
//}


// 11.
//string wood = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
//string[] splits = wood.Split(' ');

//for (int i = 0; i < splits.Length; i++)
//{
//    for (int j = 0; j <= i; j++)
//    {
//        Console.Write(splits[j] + " ");
//    }
//    Console.WriteLine();
//}


// 12.
//string wood = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
//string[] splits = wood.Split(' ');

//for (int i = 0; i < splits.Length; i++)
//{
//    Console.ForegroundColor = ConsoleColor.White;

//    for (int j = 0; j < splits.Length; j++)
//    {
//        if (j <= i)
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//        }
//        else
//        {
//            Console.ForegroundColor = ConsoleColor.White;
//        }

//        Console.Write(splits[j] + " ");
//    }

//    Console.WriteLine();
//}


// 13.
//string alfa = "abcdefghijklmnopqrstuvwxyz";

//for (int i = 0; i < alfa.Length - 4; i++)
//{
//    Console.ForegroundColor = ConsoleColor.White;

//    for (int j = 0; j < alfa.Length; j++)
//    {
//        if (j >= i && j < i + 5)
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//        }
//        else
//        {
//            Console.ForegroundColor = ConsoleColor.White;
//        }
//        Console.Write(alfa[j]);


//    }
//    Console.WriteLine();
//}


// 14.
//Console.WriteLine("Mata in valfri sträng: ");
//string input = Console.ReadLine();
//char detect = input[0];
//Console.ForegroundColor = ConsoleColor.Red;
//for (int i = 0; i < input.Length; i++)
//{
//    if (i != 0 && input[0] == input[i])
//    {
//        Console.ForegroundColor = ConsoleColor.Gray;
//        Console.Write(input[i]);
//    }
//    else
//        Console.Write(input[i]);
//}


// 15.
//Console.Write("Mata in valfri sträng: ");
//string input = "ajdfhvajhdfd"; //Console.ReadLine();

//// Loopa igenom varje tecken i strängen
//for (int i = 0; i < input.Length; i++)
//{
//    // Kolla om samma tecken finns igen senare i strängen
//    int nästaSammaTecken = -1;
//    for (int k = i + 1; k < input.Length; k++)
//    {
//        if (input[k] == input[i])
//        {
//            nästaSammaTecken = k;
//            break;
//        }
//    }

//    // Skriv ut hela strängen med färg
//    for (int j = 0; j < input.Length; j++)
//    {
//        if (nästaSammaTecken != -1 && j >= i && j <= nästaSammaTecken)
//            Console.ForegroundColor = ConsoleColor.Red; // Markera tecken mellan dubbletter
//        else
//            Console.ForegroundColor = ConsoleColor.Gray;

//        Console.Write(input[j]);
//    }

//    Console.WriteLine();
//}

//// Återställ färgen till standard
//Console.ResetColor();