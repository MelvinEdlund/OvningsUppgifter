

using System.Linq;
//1
var people = new[]
{
    new {FirstName = "Sebbe", LastName = "Breuk", Age = 24, Height = 188, Weight = 79 },
    new {FirstName = "Melle", LastName = "Edlund", Age = 24, Height = 190, Weight = 81 },
    new {FirstName = "Sebastian", LastName = "Breuker", Age = 14, Height = 179, Weight = 80 },
    new {FirstName = "zMelvin", LastName = "Edlund", Age = 24, Height = 191, Weight = 82 },
    new {FirstName = "Reza", LastName = "Mohama", Age = 23, Height = 164, Weight = 70 },
    new {FirstName = "Fredrik", LastName = "Persson", Age = 36, Height = 168, Weight = 57 },
    new {FirstName = "Diddy", LastName = "Diddson", Age = 44, Height = 147, Weight = 57 },
    new {FirstName = "Danny", LastName = "Dannysson", Age = 73, Height = 175, Weight = 90 }
};
// Method-Syntax
////2
//var checkAgeList = people
//    .Where(p => p.Age >= 20 && p.Age <= 40)
//    .ToList();

////3
//checkAgeList.Where(p => p.Height > 190)
//    .ToList()
//    .ForEach(p => Console.WriteLine(p.FirstName));
////4
//var longerFirstNameList = people
//    .Where(p => p.FirstName.Length > p.LastName.Length)
//    .Select(p => new {p.FirstName, p.LastName})
//    .ToList();
////5
//var bmiList = people
//    .Select(p => new
//    {
//        Name = $"{p.FirstName} {p.LastName}",
//        BMI = p.Weight / Math.Pow(p.Height / 100.0, 2)
//    })
//    .ToList();
////6
//var filteredBmiList = bmiList
//    .Where(p => p.BMI < 20 || p.BMI > 25)
//    .ToList();

////7
//var filterPeopleBmiList = people
//    .Select(p => new
//    {
//        Name = $"{p.FirstName} {p.LastName}",
//        BMI = p.Weight / Math.Pow(p.Height / 100.0, 2)
//    })
//    .Where(p => p.BMI < 20 || p.BMI > 25);


////8
//var userNameCategory = people
//    .Select(p => new
//    {
//        Username = $"{p.FirstName}{p.Age}",
//        Category = p.Age < 18 ? "Child" : "Adult"
//    })
//    .ToList();

//userNameCategory.ForEach(u =>
//Console.WriteLine($"{u.Username}, {u.Category}"));

//9
// Query-Syntax

// 2, 3
var checkAgeAndHeight = from p in people 
               where p.Age <= 40 && p.Age >= 20 && p.Height > 190
               select $"{p.FirstName} är {p.Age} år";
foreach (var p in checkAgeAndHeight) Console.WriteLine(p);

// 4
var longerFirstNames = from p in people
                       where p.FirstName.Length > p.LastName.Length
                       select new
                       {
                           FirstName = p.FirstName,
                           LastName = p.LastName
                       };
foreach(var p in longerFirstNames) Console.WriteLine(p.FirstName +" " +p.LastName);

//5
var bmiList = from p in people
              select new
              {
                  Name = $"{p.FirstName} {p.LastName}",
                  BMI = p.Weight / Math.Pow(p.Height / 100.0, 2)
              };

//6
var filteredBmiList = from p in bmiList
                      where p.BMI < 20 || p.BMI > 25
                      select p;

//7
var filteredPeopleBmiList = from p in people
                            let bmi = p.Weight / Math.Pow(p.Height / 100.0, 2)
                            where bmi < 20 || bmi > 25
                            select new
                            {
                                Name = $"{p.FirstName} {p.LastName}",
                                BMI = bmi
                            };

// 8
var userNamesCategory = from p in people
                        let category = p.Age < 18 ? "child" : "Adult"
                        select new
                        {
                            Username = $"{p.FirstName}{p.Age}",
                            Category = category
                        };

foreach (var p in userNamesCategory)
{
    Console.WriteLine(p.Username + " " +p.Category);
}

// 10
var sortedByHeight = people
    .OrderBy(p => p.Height);

foreach (var p in people)
{
    Console.WriteLine($"{p.FirstName} {p.LastName} - {p.Height} cm");
}

// 11
var sortedByAge = people
    .OrderBy(p => p.Age);

foreach (var p in sortedByAge)
{
    Console.WriteLine($"{p.FirstName} {p.LastName} - {p.Age} år");

}

// 12
var sortedByLastName = people
    .OrderBy(p => p.LastName)
    .ThenByDescending(p => p.FirstName);

foreach (var p in sortedByLastName)
{
    Console.WriteLine($"{p.FirstName} {p.LastName}");

}