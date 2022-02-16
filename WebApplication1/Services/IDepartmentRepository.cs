using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IDepartmentRepository
    {
        int Create(Department department);
        int Update(int id, Department department);
        int Delete(int id);
        List<Department> getAll();
        Department getById(int id);
        Department getByName(string Name);
    }
}
