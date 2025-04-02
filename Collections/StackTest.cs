using System;
using System.Collections;

namespace DailyWork.Collections
{
    internal class StackTest
    {
        Stack stack = new Stack();

        public StackTest()
        {
            stack.Push("Alice");
            stack.Push(25);
            stack.Push(3.14);
            stack.Push(true);

            Console.WriteLine("Stack after pushing elements:");
            PrintStack(stack);

            Console.WriteLine($"\nTop element: {stack.Peek()}");

            stack.Push("Bob");
            Console.WriteLine("\nStack after pushing 'Bob':");
            PrintStack(stack);

            stack.Pop();
            Console.WriteLine("\nStack after popping top element:");
            PrintStack(stack);

            Console.WriteLine($"\nDoes stack contain 'Alice'? {stack.Contains("Alice")}");
            Console.WriteLine($"Does stack contain 3.14? {stack.Contains(3.14)}");

            stack.Clear();
            Console.WriteLine("\nStack after clearing:");
            PrintStack(stack);
        }

        public void PrintStack(Stack stack)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
