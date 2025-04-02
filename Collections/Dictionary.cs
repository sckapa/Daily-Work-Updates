using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWork.Collections
{
    internal class DictionaryTest
    {
        public Dictionary<string, int> studentScores = new Dictionary<string, int>();

        public DictionaryTest()
        {
            studentScores.Add("Alice", 85);
            studentScores.Add("Bob", 92);
            studentScores.Add("Charlie", 78);

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
}
