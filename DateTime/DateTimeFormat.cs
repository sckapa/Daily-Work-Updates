using System;
using System.Globalization;

namespace DailyWork
{
    internal class DateTimeFormattingTest
    {
        public DateTimeFormattingTest()
        {
            DateTime now = DateTime.Now;
            DateTime customDate = new DateTime(2025, 4, 2, 14, 30, 15);

            Console.WriteLine("Current DateTime:");
            Console.WriteLine(now);

            Console.WriteLine("\nStandard DateTime Formats:");
            Console.WriteLine($"Full Date: {customDate:D}");
            Console.WriteLine($"Short Date: {customDate:d}");
            Console.WriteLine($"Full Time: {customDate:T}");
            Console.WriteLine($"Short Time: {customDate:t}");
            Console.WriteLine($"Full DateTime: {customDate:F}");
            Console.WriteLine($"General DateTime (Long): {customDate:G}");
            Console.WriteLine($"General DateTime (Short): {customDate:g}");

            Console.WriteLine("\nCustom DateTime Formats:");
            Console.WriteLine($"Year-Month-Day: {customDate:yyyy-MM-dd}");
            Console.WriteLine($"Day/Month/Year: {customDate:dd/MM/yyyy}");
            Console.WriteLine($"Month-Day-Year: {customDate:MM-dd-yyyy}");
            Console.WriteLine($"Hour:Minute:Second: {customDate:HH:mm:ss}");
            Console.WriteLine($"12-Hour Time: {customDate:hh:mm tt}");
            Console.WriteLine($"Full Custom Format: {customDate:dddd, MMMM dd, yyyy HH:mm:ss}");

            Console.WriteLine("\nISO 8601 Format:");
            Console.WriteLine(customDate.ToString("yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture));

            Console.WriteLine("\nCulture-Specific Formatting:");
            CultureInfo culture = new CultureInfo("fr-FR");
            Console.WriteLine($"French Date Format: {customDate.ToString("D", culture)}");

            Console.WriteLine("\nUnix Timestamp:");
            long unixTime = ((DateTimeOffset)customDate).ToUnixTimeSeconds();
            Console.WriteLine($"Unix Time (Seconds): {unixTime}");
        }
    }
}
