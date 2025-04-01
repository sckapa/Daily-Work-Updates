using System;
using System.Collections.Generic;

class SortedListTest
{
    private SortedList<string, int> studentScores = new SortedList<string, int>();

    public SortedListTest()
    {
        studentScores.Add("Charlie", 78);
        studentScores.Add("Alice", 85);
        studentScores.Add("Bob", 92);

        Console.WriteLine("Student Scores:");
        PrintAll();

        studentScores["Alice"] = 90;
        Console.WriteLine("\nAlice's updated score: " + studentScores["Alice"]);

        studentScores.Remove("Charlie");
        Console.WriteLine("\nAfter removing Charlie:");

        PrintAll();

        Console.WriteLine("\nContains 'Bob'?: " + studentScores.ContainsKey("Bob"));
        Console.WriteLine("Contains 'Charlie'?: " + studentScores.ContainsKey("Charlie"));
    }

    public void PrintAll()
    {
        foreach (var kvp in studentScores)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}