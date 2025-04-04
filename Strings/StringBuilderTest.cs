using System;
using System.Text;

namespace DailyWork
{
    internal class StringBuilderTest
    {
        public StringBuilderTest()
        {
            StringBuilder sb = new StringBuilder("Hello, World!");
            Console.WriteLine($"Original StringBuilder: {sb}");

            Console.WriteLine("\nAppending Strings:");
            sb.Append(" C# is awesome.");
            Console.WriteLine(sb);

            Console.WriteLine("\nAppending Line:");
            sb.AppendLine(" This is a new line.");
            Console.WriteLine(sb);

            Console.WriteLine("\nInserting Text:");
            sb.Insert(7, "Beautiful ");
            Console.WriteLine(sb);

            Console.WriteLine("\nReplacing Text:");
            sb.Replace("World", "Universe");
            Console.WriteLine(sb);

            Console.WriteLine("\nRemoving Characters:");
            sb.Remove(0, 7);
            Console.WriteLine(sb);

            Console.WriteLine("\nGetting String Length & Capacity:");
            Console.WriteLine($"Length: {sb.Length}, Capacity: {sb.Capacity}");

            Console.WriteLine("\nEnsuring Capacity (Min 100):");
            sb.EnsureCapacity(100);
            Console.WriteLine($"New Capacity: {sb.Capacity}");

            Console.WriteLine("\nConverting to String:");
            string result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}
