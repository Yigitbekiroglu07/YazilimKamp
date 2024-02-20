using System;
namespace Interfaces;

class Program
{
    static void Main(String[] args)
    {
        ICustomerDal[] customerDals = new ICustomerDal[2]
        {
            new SqlServerCustomerDal(),
            new OracleCustomerDal(),
        };

        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new SqlServerCustomerDal());
        PersonManager manager = new PersonManager();
        Customer customer = new Customer
        {
            Id = 1,
            FirstName = "Yiğit",
            LastName = "Bekiroğlu",
            Adress = "Ankara"

        };
        Student student = new Student
        {
            Id = 1,
            FirstName = "Ahmet",
            LastName = "Bekiroğlu",
            Adress = "Ankara",
            Department = "Bilgisayar Mühendisliği"
        };
        manager.Add(customer);
        manager.Add(student);
    }

    interface IPerson
    {
        int Id { get; set; }    
        string FirstName { get; set; }

        string LastName { get; set; }

        string Adress { get; set; }
    }

    class Customer: IPerson
    {
       public int Id { get; set; }
       public string FirstName { get; set; }

       public string LastName { get; set; }

        public string Adress { get; set; }

    }
    class Student : IPerson 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Adress { get; set; }

        public string Department { get; set; }  
    }

    class PersonManager
    {
        public void Add(IPerson person) 
        {
            Console.Write(person.FirstName);  
        }
    }


}
