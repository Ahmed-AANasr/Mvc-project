using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class CoursesRepository : ICoursesRepository
    {
        DBRelations context;
        public CoursesRepository(DBRelations _context)
        {
            context = _context;
        }
        public int Create(Courses Courses)
        {
            context.Course.Add(Courses);
            return context.SaveChanges();
        }
        public int Delete(int id)
        {
            Courses InstFromDB = context.Course.FirstOrDefault(i => i.Id == id);
            context.Course.Remove(InstFromDB);
            return context.SaveChanges();
        }
        public List<Courses> getAll()
        {
            return context.Course.ToList();
        }
        public Courses getById(int id)
        {
            var getDepById = context.Course.FirstOrDefault(i => i.Id == id);
            return getDepById;
        }
        public Courses getByName(string Name)
        {
            var instByName = context.Course.FirstOrDefault(i => i.Name == Name);
            return instByName;
        }
        public int Update(int id, Courses courses)
        {
            Courses InstFromDB = context.Course.FirstOrDefault(i => i.Id == id);
            InstFromDB.Name = courses.Name;
            InstFromDB.Degree = courses.Degree;
            InstFromDB.MinDegree = courses.MinDegree;
            InstFromDB.dep_id = courses.dep_id;
            return context.SaveChanges();
        }
    }
}
