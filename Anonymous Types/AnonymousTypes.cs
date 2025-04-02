using System;
using System.Collections.Generic;

namespace DailyWork.AnonymousTypes
{
    class Person
    {
        public string Name { get; set; } = "Rohit";
        public int Age { get; set; } = 34;
    }

    internal class AnonymousTypeTest
    {
        public AnonymousTypeTest()
        {
            Person p = new Person();

            var person = new {PersonName=p.Name, Age = p.Age};

            Console.WriteLine(person.PersonName);
            Console.WriteLine(person.Age);

            //person.PersonName = "Name"; (Immutable)

            var arr = new[]
            {
                new {PersonName="Ashish", Age=50},
                new {PersonName="Anish", Age=30}
            };

            foreach (var item in arr)
            {
                Console.WriteLine(item.PersonName);
                Console.WriteLine(item.Age);
            }
        }
    }
}
