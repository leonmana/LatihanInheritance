using System;
using System.Collections.Generic;
using System.Text;

namespace latihaninheritance
{
    public class Person
    {
         public Person(string name, int age)
        {
            Name=name;
            Age=age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public void GetNameAndAge()
        {
            Console.WriteLine("The person has name: {0} and age: {1}", Name, Age);
        }
    }
}
