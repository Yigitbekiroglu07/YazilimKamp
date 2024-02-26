using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    List<Instructor> _instructors;  
    public InstructorDal()
    {
        Instructor instructors1 = new Instructor();
        instructors1.FirstName = "Engin";
        instructors1.LastName = "Demiroğ";
        instructors1.InstructorId = 1;

        Instructor instructors2 = new Instructor();
        instructors2.FirstName = "Halit Enes";
        instructors2.LastName = "Kalaycı";
        instructors2.InstructorId = 2;


        _instructors = new List<Instructor>() { instructors1, instructors2 };
    }

    public void Add(Instructor instructor)
    {
       _instructors.Add(instructor);    
    }

    public void Delete(Instructor instructor)
    {
        Instructor instructorToDelete = _instructors.SingleOrDefault(i => i.FirstName == instructor.FirstName);
        if (instructorToDelete != null)
        {
            _instructors.Remove(instructorToDelete);
        }
        else
        {

        }
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public void Update(Instructor instructor)
    {
        var instructorId = _instructors.FirstOrDefault(i => i.InstructorId == instructor.InstructorId);
        if (instructorId != null)
        {
            instructorId.FirstName = instructor.FirstName;
            instructorId.LastName = instructor.LastName;
            instructorId.InstructorId = instructor.InstructorId;
        }
    }
}
