

// 1
static string GetFullName(string firstName, string lastName)
{
    return firstName + " " + lastName;

}

// 2
static string FullNameRow(string firstName, string lastName)
{
    return $"firstName: {firstName}\nlastName: {lastName}";
}

// 3
static void PrintNames(Func<string, string, string> formatter)
{
    string[] firstNames = { "Sebbe", "Melle", "Melvin" };
    string[] lastNames = { "Breuker", "edl", "Edlund" };

    for (int i = 0; i < firstNames.Length; i++)
    {
        Console.WriteLine(formatter(firstNames[i], lastNames[i]));
    }

}
Func<string, string, string> del = GetFullName;

Console.WriteLine("Med FullNameRow: ");
PrintNames(FullNameRow);

Console.WriteLine("\nMed del = GetFullName");
PrintNames(del);

Console.WriteLine();

// 4
Action<int, int> printSum = (a, b) =>
{
    Console.WriteLine($"Summan av {a} + {b} = {a + b}");
};

printSum(5, 2);
printSum(7, 135);

// 5
Func<int, int, int> returnSum = (a, b) => a + b;

Console.WriteLine(returnSum(5, 32));

Console.WriteLine();

// 6
PrintNames((first, last) =>
    $"firstName has {first.Length} letters, lastName has {last.Length} letters.");


// 7
static void ModOutput(string[] city, Func<string, string> modifier)
{
    city.ToList().ForEach(city =>
     {
         Console.WriteLine(modifier(city));
     });
}


string[] cities = new[]
{
    "Sweden",
    "Denmark",
    "Finland",
    "Norway",
    "Island"
};

Console.WriteLine("UPPERCASE:");
ModOutput(cities, c => c.ToUpper());

Console.WriteLine("\nFörsta 3 tecknen:");
ModOutput(cities, c => c.Substring(0, 3));

Console.WriteLine("\nLängden på namnet:");
ModOutput(cities, c => $"{c} ({c.Length} bokstäver)");

Console.WriteLine();

// 8
static int[] FilterArray(int[] numbers, Func<int, bool> check)
{
    List<int> result = new();

    foreach (var n in numbers)
    {
        if (check(n))
        {
            // Console.WriteLine(n);
            result.Add(n);
        }
    }
    return result.ToArray();
}

int[] numbers = { -5, -1, 0, 4, 8, 12, 15, 19, 22, 30 };

//Console.WriteLine("Negativa tal:");
//FilterArray(numbers, n => n < 0);

//Console.WriteLine("\nTal mellan 10 och 20:");
//FilterArray(numbers, n => n >= 10 && n <= 20);

//Console.WriteLine("\nJämna tal:");
//FilterArray(numbers, n => n % 2 == 0);

// 9
Console.WriteLine("Negativa tal:");

FilterArray(numbers, n => n < 0).ToList().ForEach(n => Console.WriteLine(n));

Console.WriteLine("\nTal mellan 10 och 20:");
FilterArray(numbers, n => n >= 10 && n <= 20).ToList().ForEach(n => Console.WriteLine(n));

Console.WriteLine("\nJämna tal:");
FilterArray(numbers, n => n % 2 == 0).ToList().ForEach(n => Console.WriteLine(n));