using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService // Interface'de sadece imzalar olur. Method içi boş kalır.
    {

        void ApplyForMask(Person person); // Maske için başvur



        List<Person> GetList();



        bool CheckPerson(Person person);

    }
       
    
}

