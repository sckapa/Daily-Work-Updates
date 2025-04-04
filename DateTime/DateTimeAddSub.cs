using System;

namespace DailyWork
{
    internal class DateTimeCalculationTest
    {
        public DateTimeCalculationTest()
        {
            DateTime today = DateTime.Now;
            DateTime customDate = new DateTime(2025, 4, 2, 14, 30, 0);

            Console.WriteLine("Current DateTime:");
            Console.WriteLine(today);

            Console.WriteLine("\nAdding Time:");
            Console.WriteLine($"Add 5 Days: {customDate.AddDays(5)}");
            Console.WriteLine($"Add 2 Weeks: {customDate.AddDays(14)}");
            Console.WriteLine($"Add 3 Months: {customDate.AddMonths(3)}");
            Console.WriteLine($"Add 1 Year: {customDate.AddYears(1)}");
            Console.WriteLine($"Add 10 Hours: {customDate.AddHours(10)}");
            Console.WriteLine($"Add 45 Minutes: {customDate.AddMinutes(45)}");
            Console.WriteLine($"Add 30 Seconds: {customDate.AddSeconds(30)}");

            Console.WriteLine("\nSubtracting Time:");
            Console.WriteLine($"Subtract 7 Days: {customDate.AddDays(-7)}");
            Console.WriteLine($"Subtract 6 Months: {customDate.AddMonths(-6)}");
            Console.WriteLine($"Subtract 2 Years: {customDate.AddYears(-2)}");
            Console.WriteLine($"Subtract 90 Minutes: {customDate.AddMinutes(-90)}");

            Console.WriteLine("\nDifference Between Dates:");
            DateTime futureDate = new DateTime(2026, 6, 10);
            TimeSpan difference = futureDate - customDate;
            Console.WriteLine($"Days Difference: {difference.TotalDays}");
            Console.WriteLine($"Hours Difference: {difference.TotalHours}");
            Console.WriteLine($"Minutes Difference: {difference.TotalMinutes}");

            Console.WriteLine("\nUsing TimeSpan for Custom Addition:");
            TimeSpan duration = new TimeSpan(10, 30, 0); 
            Console.WriteLine($"Add 10 hours 30 minutes: {customDate + duration}");
            Console.WriteLine($"Subtract 10 hours 30 minutes: {customDate - duration}");
        }
    }
}
