using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer {FirstName = "Ali Rıza" },
                new Student {FirstName = "Sahin" },
                new Person {FirstName = "Mahmut" }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.Read();

        }
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public String LastName { get; set; }
        }

        class Customer : Person
        {
            public string City { get; set; }
        }
        class Student : Person
        {
            public string Departman { get; set; }
        }
    }
}
