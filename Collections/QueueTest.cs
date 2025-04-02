using System;
using System.Collections;

namespace DailyWork.Collections
{
    internal class QueueTest
    {
        Queue queue = new Queue();

        public QueueTest()
        {
            queue.Enqueue("John");
            queue.Enqueue(45);
            queue.Enqueue(9.8);
            queue.Enqueue("Hello");

            Console.WriteLine("Queue after enqueueing elements:");
            PrintQueue(queue);

            Console.WriteLine($"\nPeek at the front element: {queue.Peek()}");

            queue.Enqueue("World");
            Console.WriteLine("\nQueue after enqueueing 'World':");
            PrintQueue(queue);

            queue.Dequeue();
            Console.WriteLine("\nQueue after dequeuing front element:");
            PrintQueue(queue);

            Console.WriteLine($"\nDoes queue contain 'John'? {queue.Contains("John")}");
            Console.WriteLine($"Does queue contain 9.8? {queue.Contains(9.8)}");

            queue.Clear();
            Console.WriteLine("\nQueue after clearing:");
            PrintQueue(queue);
        }

        public void PrintQueue(Queue queue)
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
