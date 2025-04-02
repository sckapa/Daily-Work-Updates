using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWork.Collections
{
    internal class HashTableTest
    {
        Hashtable ht = new Hashtable();

        public HashTableTest()
        {
            ht.Add(1, "Alice");
            ht.Add("Two", 2);
            ht.Add(3, null);

            Console.WriteLine("Hashtable Data:");
            PrintAll();

            ht[1] = "Bob";
            ht["Two"] = 5;
            ht[3] = "Updated";

            PrintAll();

            ht.Remove(1);

            PrintAll();
        }

        public void PrintAll()
        {
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }
    }
}
