using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyWork
{
    internal class LinqTest
    {
        public LinqTest()
        {
            List<(string Name, int Age, string City)> people = new List<(string, int, string)>
            {
                ("Alice", 25, "New York"),
                ("Bob", 30, "Los Angeles"),
                ("Charlie", 35, "Chicago"),
                ("David", 40, "San Francisco"),
                ("Eve", 28, "Houston")
            };

            Console.WriteLine("Original List:");
            PrintList(people);

            var sortedByAge = people.OrderBy(p => p.Age).ToList();
            Console.WriteLine("\nList sorted by Age:");
            PrintList(sortedByAge);

            var firstPerson = people.First();
            Console.WriteLine($"\nFirst person: {firstPerson.Name}, {firstPerson.Age}, {firstPerson.City}");

            var firstOrDefaultPerson = people.FirstOrDefault(p => p.Age > 50);
            Console.WriteLine($"\nFirstOrDefault person (Age > 50): {(firstOrDefaultPerson == default ? "None" : firstOrDefaultPerson.Name)}");

            var lastPerson = people.Last();
            Console.WriteLine($"\nLast person: {lastPerson.Name}, {lastPerson.Age}, {lastPerson.City}");

            var lastOrDefaultPerson = people.LastOrDefault(p => p.Age < 20);
            Console.WriteLine($"\nLastOrDefault person (Age < 20): {(lastOrDefaultPerson == default ? "None" : lastOrDefaultPerson.Name)}");

            var thirdPerson = people.ElementAt(2);
            Console.WriteLine($"\nElement at index 2: {thirdPerson.Name}, {thirdPerson.Age}, {thirdPerson.City}");

            var elementAtOrDefaultPerson = people.ElementAtOrDefault(10);
            Console.WriteLine($"\nElementAtOrDefault at index 10: {(elementAtOrDefaultPerson == default ? "None" : elementAtOrDefaultPerson.Name)}");

            try
            {
                var singlePerson = people.Single(p => p.Name == "Charlie");
                Console.WriteLine($"\nSingle person with name 'Charlie': {singlePerson.Name}, {singlePerson.Age}, {singlePerson.City}");
            }
            catch (Exception)
            {
                Console.WriteLine("\nSingle() failed: More than one or no match found");
            }

            var singleOrDefaultPerson = people.SingleOrDefault(p => p.Name == "Zoe");
            Console.WriteLine($"\nSingleOrDefault person with name 'Zoe': {(singleOrDefaultPerson == default ? "None" : singleOrDefaultPerson.Name)}");

            var names = people.Select(p => p.Name).ToList();
            Console.WriteLine("\nList of Names:");
            names.ForEach(Console.WriteLine);

            var minAge = people.Min(p => p.Age);
            Console.WriteLine($"\nMinimum Age: {minAge}");

            var maxAge = people.Max(p => p.Age);
            Console.WriteLine($"\nMaximum Age: {maxAge}");

            var averageAge = people.Average(p => p.Age);
            Console.WriteLine($"\nAverage Age: {averageAge}");

            var totalPeople = people.Count();
            Console.WriteLine($"\nTotal People Count: {totalPeople}");

            var sumOfAges = people.Sum(p => p.Age);
            Console.WriteLine($"\nSum of all ages: {sumOfAges}");
        }

        public static void PrintList(List<(string Name, int Age, string City)> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Name: {item.Name}, Age: {item.Age}, City: {item.City}");
            }
        }
    }
}
