using System;
using System.Text.RegularExpressions;

namespace DailyWork
{
    internal class MathAndRegexTest
    {
        public MathAndRegexTest()
        {
            Console.WriteLine("Math Operations:");
            MathOperations();

            Console.WriteLine("\nRegular Expression Tests:");
            RegexTests();
        }

        public static void MathOperations()
        {
            double num1 = 25.5, num2 = 4;

            Console.WriteLine($"Absolute Value of -10: {Math.Abs(-10)}");
            Console.WriteLine($"Square Root of {num1}: {Math.Sqrt(num1)}");
            Console.WriteLine($"Power of {num1}^2: {Math.Pow(num1, 2)}");
            Console.WriteLine($"Ceiling of {num1}: {Math.Ceiling(num1)}");
            Console.WriteLine($"Floor of {num1}: {Math.Floor(num1)}");
            Console.WriteLine($"Round {num1}: {Math.Round(num1)}");
            Console.WriteLine($"Max of {num1} and {num2}: {Math.Max(num1, num2)}");
            Console.WriteLine($"Min of {num1} and {num2}: {Math.Min(num1, num2)}");
            Console.WriteLine($"Sin(30 degrees): {Math.Sin(30 * (Math.PI / 180))}");
            Console.WriteLine($"Cos(60 degrees): {Math.Cos(60 * (Math.PI / 180))}");
            Console.WriteLine($"Tan(45 degrees): {Math.Tan(45 * (Math.PI / 180))}");
            Console.WriteLine($"Log of 10: {Math.Log(10)}");
            Console.WriteLine($"Log Base 10 of 100: {Math.Log10(100)}");
            Console.WriteLine($"Random Number (0-100): {new Random().Next(0, 100)}");
        }

        public static void RegexTests()
        {
            string email = "test@example.com";
            string phone = "+1-123-456-7890";
            string text = "The price is $99.99 and the discount is 20%.";
            string pattern;

            pattern = @"^\w+@\w+\.\w+$";
            Console.WriteLine($"Is '{email}' a valid email? {Regex.IsMatch(email, pattern)}");

            pattern = @"^\+\d{1,3}-\d{3}-\d{3}-\d{4}$";
            Console.WriteLine($"Is '{phone}' a valid phone number? {Regex.IsMatch(phone, pattern)}");

            pattern = @"\$\d+\.\d{2}";
            Match match = Regex.Match(text, pattern);
            Console.WriteLine($"Extracted price from text: {match.Value}");

            pattern = @"\b\w{5}\b";
            MatchCollection matches = Regex.Matches(text, pattern);
            Console.WriteLine("Words with exactly 5 letters:");
            foreach (Match m in matches)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
