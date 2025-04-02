using System;
using System.Collections.Generic;

namespace DailyWork
{
    internal class TupleTest
    {
        public TupleTest()
        {
            List<Tuple<string, int, string>> people = new List<Tuple<string, int, string>>
            {
                Tuple.Create("Alice", 25, "New York"),
                Tuple.Create("Bob", 30, "Los Angeles"),
                Tuple.Create("Charlie", 35, "Chicago")
            };

            Console.WriteLine("List of Tuples:");
            PrintList(people);

            people[1] = Tuple.Create("David", 40, "San Francisco");
            Console.WriteLine("\nList after modifying second entry:");
            PrintList(people);

            people.Add(Tuple.Create("Eve", 28, "Houston"));
            Console.WriteLine("\nList after adding a new entry:");
            PrintList(people);

            people.RemoveAt(0);
            Console.WriteLine("\nList after removing the first entry:");
            PrintList(people);

            bool containsBob = people.Exists(p => p.Item1 == "Bob");
            Console.WriteLine($"\nDoes list contain 'Bob'? {containsBob}");

            people.Clear();
            Console.WriteLine("\nList after clearing:");
            PrintList(people);
        }

        public static void PrintList(List<Tuple<string, int, string>> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Name: {item.Item1}, Age: {item.Item2}, City: {item.Item3}");
            }
        }
    }
}
