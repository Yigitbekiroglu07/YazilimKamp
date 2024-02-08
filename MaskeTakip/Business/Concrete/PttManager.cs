using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //IApplicantService'a bağımlı olduğundan parametre içine yazılmalı
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            // PersonManager personManager = new PersonManager();  // CheckPerson'u çağırmak için PersonManager newlendi.
            if (_applicantService.CheckPerson(person)) // _applicantService.CheckPerson(person) == true ile aynı anlamlı
            {
                Console.WriteLine(person.FirstName + " için maske verildi "); 
            }
        }
    }
}
