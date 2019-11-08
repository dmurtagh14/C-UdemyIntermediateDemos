using System;

namespace ClassesDemo
{

    public class Person
    {
        public string Name;

        public void Introduce(string personTo)
        {
            Console.WriteLine("Hi {0}, I am {1}! " + personTo, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "Danny";

            var person2 = Person.Parse("John");

            person.Introduce("Pete");

            person.Introduce("Dave"); //instance method
        }
    }
}
