using System;
namespace Classes;

class Program
{
    static void Main(String[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.Update();   

        Customer customer = new Customer();
        customer.City = "Ankara";
        customer.Id = 1; 
        customer.FirstName = "Yiğit";
        customer.LastName = "Bekiroğlu";

        Console.WriteLine(customer.FirstName);
    }
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }
        public void Update()
        {
            Console.WriteLine("Customer uptaded!");
        }
    }
}
