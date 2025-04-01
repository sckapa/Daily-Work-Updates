using System;
using System.Collections;

namespace DailyWork
{
    internal class ArrayListTest
    {
        ArrayList arrayList = new ArrayList();

        public ArrayListTest()
        {
            arrayList.Add("Alice");
            arrayList.Add(25);
            arrayList.Add(3.14);
            arrayList.Add(true);

            Console.WriteLine("ArrayList after adding elements:");
            PrintArrayList(arrayList);

            Console.WriteLine($"\nElement at index 1: {arrayList[1]}");

            arrayList[1] = 30; 
            Console.WriteLine($"\nArrayList after modifying index 1:");
            PrintArrayList(arrayList);

            arrayList.Remove("Alice"); 
            Console.WriteLine("\nArrayList after removing 'Alice':");
            PrintArrayList(arrayList);

            arrayList.RemoveAt(1); 
            Console.WriteLine("\nArrayList after removing element at index 1:");
            PrintArrayList(arrayList);

            Console.WriteLine($"\nDoes ArrayList contain 'Alice'? {arrayList.Contains("Alice")}");
            Console.WriteLine($"Does ArrayList contain 3.14? {arrayList.Contains(3.14)}");

            arrayList.Clear();
            Console.WriteLine("\nArrayList after clearing:");
            PrintArrayList(arrayList);
        }

        public void PrintArrayList(ArrayList arrayList)
        {
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
