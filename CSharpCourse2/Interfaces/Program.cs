using System;
namespace Interfaces;

class Program
{
    static void Main(String[] args)
    {
        IPersonManager customerManager = new CustomerManager();
        customerManager.Add();

        IPersonManager employeeManager = new EmployeeManager(); 
        employeeManager.Add();  

        ProjectManager projectManager = new ProjectManager();
        projectManager.Add(new CustomerManager()); //  projectManager.Add(customerManager); ile aynı.
        projectManager.Update(employeeManager);
        
    }
    interface IPersonManager
    {
        void Add();

        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            // Müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi.");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi.");
        }

        class ProjectManager
        {
            public void Add(IPersonManager personManager) 
            {
                personManager.Add();
            }
        }

    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }  
}
