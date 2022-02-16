using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface ICoursesRepository
    {
        int Create(Courses courses);
        int Update(int id, Courses courses);
        int Delete(int id);
        List<Courses> getAll();
        Courses getById(int id);
        Courses getByName(string Name);
    }
}
