using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IInstructorRepository
    {
        int Create(Instrauctor instructor);
        int Update(int id, Instrauctor instructor);
        int Delete(int id);
        List<Instrauctor> getAll();
        Instrauctor getById(int id);
        Instrauctor getByName(string Name);
        List<Instrauctor> getInstructorsByDepId (int id);
    }
}
