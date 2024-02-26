using DataAccess.Abstract;
using DataAccess.Concretes;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class CourseManager
{
    


    private readonly ICoursesDal _courseDal;

    public CourseManager(CoursesDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Courses courses)
    {
        _courseDal.Add(courses);
    }

    public void Delete(Courses courses)
    {
        _courseDal.Delete(courses);
    }

    public List<Courses> GetAll()
    {
        return _courseDal.GetAll();
    }

    public void Update(Courses courses)
    {
        _courseDal.Update(courses);
    }
}

