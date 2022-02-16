using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class DepartmentRepository:IDepartmentRepository
    {
        DBRelations context;
        public DepartmentRepository(DBRelations _context)
        {
            context = _context;
        }
        public int Create(Department department)
        {
            context.Department.Add(department);
            return context.SaveChanges();
        }
        public int Delete(int id)
        {
            Department InstFromDB = context.Department.FirstOrDefault(i => i.Id == id);
            context.Department.Remove(InstFromDB);
            return context.SaveChanges();
        }
        public List<Department> getAll()
        {
            return context.Department.ToList();
        }
        public Department getById(int id)
        {
            var getDepById = context.Department.FirstOrDefault(i => i.Id == id);
            return getDepById;
        }
        public Department getByName(string name)
        {
            var instByName = context.Department.FirstOrDefault(i => i.Name == name);
            return instByName;
        }
        public int Update(int id, Department department)
        {
            Department InstFromDB = context.Department.FirstOrDefault(i => i.Id == id);
            InstFromDB.Name = department.Name;
            InstFromDB.Manager = department.Manager;
            return context.SaveChanges();
        }

    }
}
