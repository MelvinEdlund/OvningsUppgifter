

static string FullName(string firstName, string lastName)
{
    return $"{firstName} {lastName}";
}

Func<string, string, string> fullName = FullName;

Console.WriteLine(FullName("sebbe", "Breuker"));