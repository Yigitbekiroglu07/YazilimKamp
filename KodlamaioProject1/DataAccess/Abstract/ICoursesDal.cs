﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract;

public interface ICoursesDal
{
      
    List<Courses> GetAll();
    void Add(Courses courses);
    void Delete(Courses courses);
    void Update(Courses courses);


}
