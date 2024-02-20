using System;
namespace Inheritance;

class Program
{
    static void Main(String[] args)
    {
        Person[] persons = new Person[2]
        {
            new Customer
            {FirstName = "Yiğt"},
            new Student
            {FirstName = "Bedia"},

        };

        foreach (var person in persons)
        {
            Console.WriteLine(person.FirstName);
        }

    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }    

        public string LastName { get; set; }
    }

    class Customer:Person 
    {
        public string City { get; set; }    
    }  
    
    class Student:Person
    {
        public string department { get; set; }  
    }

}

