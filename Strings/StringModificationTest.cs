using System;
using System.Collections.Generic;

namespace DailyWork
{
    internal class StringModificationTest
    {
        public StringModificationTest()
        {
            string original = "  Hello, World! C# is awesome.  ";
            string sentence = "The quick brown fox jumps over the lazy dog.";
            string csvData = "Alice,Bob,Charlie,David";

            Console.WriteLine("Original String:");
            Console.WriteLine($"'{original}'");

            Console.WriteLine("\nTrim Operations:");
            Console.WriteLine($"Trimmed: '{original.Trim()}'");
            Console.WriteLine($"Trim Start: '{original.TrimStart()}'");
            Console.WriteLine($"Trim End: '{original.TrimEnd()}'");

            Console.WriteLine("\nCase Modification:");
            Console.WriteLine($"To Upper: {original.ToUpper()}");
            Console.WriteLine($"To Lower: {original.ToLower()}");

            Console.WriteLine("\nReplace & Remove:");
            Console.WriteLine($"Replace 'World' with 'Universe': {original.Replace("World", "Universe")}");
            Console.WriteLine($"Remove 'C#': {original.Replace("C#", "").Trim()}");

            Console.WriteLine("\nSubstring & Index:");
            Console.WriteLine($"Substring (7,5): {original.Substring(7, 5)}");
            Console.WriteLine($"Index of 'C#': {original.IndexOf("C#")}");
            Console.WriteLine($"Last Index of 'o': {original.LastIndexOf('o')}");

            Console.WriteLine("\nString Insertion:");
            Console.WriteLine($"Insert 'Welcome' at start: {original.Insert(0, "Welcome! ")}");

            Console.WriteLine("\nString Splitting:");
            string[] words = sentence.Split(' ');
            Console.WriteLine("Splitting sentence into words:");
            PrintList(words);

            Console.WriteLine("\nJoining Strings:");
            Console.WriteLine($"Joining CSV data: {string.Join(" | ", csvData.Split(','))}");

            Console.WriteLine("\nChecking Prefix & Suffix:");
            Console.WriteLine($"Starts with 'Hello': {original.Trim().StartsWith("Hello")}");
            Console.WriteLine($"Ends with 'awesome.': {original.Trim().EndsWith("awesome.")}");

            Console.WriteLine("\nCharacter Removal:");
            Console.WriteLine($"Removing first 5 characters: {original.Remove(0, 5)}");

            Console.WriteLine("\nString Reversal:");
            Console.WriteLine($"Reversed String: {ReverseString(original.Trim())}");
        }

        public static void PrintList(string[] list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
