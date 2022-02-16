using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DepartmentController : Controller
    {
        DBRelations context = new DBRelations();
        public IActionResult Index()
        {
            var depatments = context.Department.ToList();
            return View(depatments);
        }
    }
}
