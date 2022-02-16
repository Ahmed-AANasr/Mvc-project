using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class InstructorRepository : IInstructorRepository
    {
        DBRelations context;
        public InstructorRepository(DBRelations _context)
        {
            context = _context;
        }
        public int Create(Instrauctor instructor)
        {
           context.Instrauctor.Add(instructor);
           return context.SaveChanges();
        }
        public int Delete(int id)
        {
            Instrauctor InstFromDB = context.Instrauctor.FirstOrDefault(i => i.ID == id);
            context.Instrauctor.Remove(InstFromDB);
            return context.SaveChanges();
        }
        public List<Instrauctor> getAll()
        {
            return context.Instrauctor.Include(i => i.dep).Include(i => i.crs).ToList(); 

        }
        public Instrauctor getById(int id)
        {
            var getInstById = context.Instrauctor.FirstOrDefault(i => i.ID == id);
            return getInstById;
        }
        public Instrauctor getByName(string name)
        {
            var instByName = context.Instrauctor.FirstOrDefault(i => i.Name == name);
            return instByName;
        }
        public List<Instrauctor> getInstructorsByDepId(int id)
        {
            List<Instrauctor> instr =
                context.Instrauctor.Include(i => i.dep).Include(i => i.crs).Where(i => i.dep_id == id).ToList();
            return instr;
        }
        public int Update(int id, Instrauctor instructor)
        {
            Instrauctor InstFromDB = context.Instrauctor.FirstOrDefault(i => i.ID == id);
            InstFromDB.Name = instructor.Name;
            InstFromDB.Salary = instructor.Salary;
            InstFromDB.Address = instructor.Address;
            InstFromDB.Image = instructor.Image;
            InstFromDB.dep_id = instructor.dep_id;
            InstFromDB.crs_id = instructor.crs_id;
            return context.SaveChanges();
        }
    }
}
