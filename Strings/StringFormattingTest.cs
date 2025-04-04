using System;
using System.Collections.Generic;
using System.Globalization;

namespace DailyWork
{
    internal class StringFormattingTest
    {
        public StringFormattingTest()
        {
            string name = "Alice";
            int age = 25;
            double price = 1234.567;
            DateTime date = new DateTime(2025, 4, 2, 14, 30, 0);

            Console.WriteLine("Basic Formatting:");
            Console.WriteLine($"Hello, {name}! You are {age} years old.");

            Console.WriteLine("\nString.Format Examples:");
            Console.WriteLine(string.Format("Name: {0}, Age: {1}", name, age));

            Console.WriteLine("\nNumber Formatting:");
            Console.WriteLine($"Currency: {price:C}");
            Console.WriteLine($"Fixed-point: {price:F2}");
            Console.WriteLine($"Scientific Notation: {price:E}");
            Console.WriteLine($"Percentage: {price / 100:P}");

            Console.WriteLine("\nDate & Time Formatting:");
            Console.WriteLine($"Full Date: {date:D}");
            Console.WriteLine($"Short Date: {date:d}");
            Console.WriteLine($"Full Time: {date:T}");
            Console.WriteLine($"Short Time: {date:t}");
            Console.WriteLine($"Custom Format: {date:yyyy-MM-dd HH:mm:ss}");

            Console.WriteLine("\nPadding & Alignment:");
            Console.WriteLine(string.Format("|{0,-10}|{1,10}|", "Left", "Right"));
            Console.WriteLine($"Padded Number: {age:D5}");

            Console.WriteLine("\nInterpolated Strings:");
            Console.WriteLine($"Formatted price: {price:0,0.00}");
            Console.WriteLine($"Hexadecimal: {age:X}");

            Console.WriteLine("\nCustom Culture Formatting:");
            CultureInfo culture = new CultureInfo("fr-FR");
            Console.WriteLine(price.ToString("C", culture));
        }
    }
}
