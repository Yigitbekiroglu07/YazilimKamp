using System;
using System.Security.Cryptography;

namespace Constructos;

class Program
{
    static void Main(String[] args)
    {
        Customer customer = new Customer()
        {
            Id = 1, 
            FirstName = "Engin", 
            LastName = "Demiroğ",  
            City = "Ankara",
        };

        Customer customer2 = new Customer(22,"Yiğit","Bekiroğlu","Antalya");
        Console.WriteLine(customer2.FirstName);
    }

    class Customer
    {
        // default constructor
        public Customer()
        {
            
        }
        public Customer(int id, string firstName, string lastname, string city)
        {
            // Console.WriteLine("Yapıcı blok çalıştı.");
            Id = id;
            FirstName = firstName;
            LastName = lastname;
            City = city;

        }
        public int Id { get; set; }

        public string FirstName { get; set;}

        public string LastName { get; set;} 

        public string City { get; set;}
    }
}
