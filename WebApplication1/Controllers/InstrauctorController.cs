using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;
using WebApplication1.ViewModel;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class InstrauctorController : Controller
    {
        IInstructorRepository _instructorRepository;
        IDepartmentRepository _departmentRepository;
        ICoursesRepository _coursesRepository;
       
        public InstrauctorController(IInstructorRepository instructorRepository, 
            IDepartmentRepository departmentRepository,
        ICoursesRepository coursesRepository
       )
        {
            _instructorRepository = instructorRepository;
            _departmentRepository = departmentRepository;
            _coursesRepository = coursesRepository;
        }

        public IActionResult CheckName(string name, int id)
        {
            Instrauctor InstFromDB = _instructorRepository.getByName(name);
            if (id == 0)
            {
                if (InstFromDB == null)
                {
                    return Json(true);
                }else
                {
                    return Json(false);
                }
            }else
            {
                if (InstFromDB == null)
                {
                    return Json(true);
                }
                else 
                {
                    if (InstFromDB.ID == id)
                    {
                        return Json(true);
                    }else
                    {
                        return Json(false);
                    }
                }
            }
        }
       
        public IActionResult GetInstructors(int id)
        {
            var instructors = _instructorRepository.getInstructorsByDepId(id);
            return PartialView("_GetParialInstructors", instructors);
        }

        public IActionResult Index()
        {
            List<Instrauctor> instr = _instructorRepository.getAll();
            return View("Index", instr);
        }

        public IActionResult Details(int id)
        {
            Instrauctor instrauctor = _instructorRepository.getById(id);
            ViewBag.dept = _departmentRepository.getAll();
            ViewBag.crs = _coursesRepository.getAll();
            return View("Details", instrauctor);
        }

        public IActionResult Add()
        {
            ViewBag.dept = _departmentRepository.getAll();
            ViewBag.crs = _coursesRepository.getAll();
            Instrauctor Inst = new Instrauctor();
            return View(Inst);
        }

        [HttpPost]
        public IActionResult SavedAddedInstruactor(Instrauctor Inst)
        {
            if (ModelState.IsValid == true)
            {
                _instructorRepository.Create(Inst);
                return RedirectToAction("Index");
            }
            ViewBag.dept = _departmentRepository.getAll();
            ViewBag.crs = _coursesRepository.getAll();
            return View("AddWithTagHelper", Inst);
        }

        public IActionResult EditForm(int id)
        {
            if (id == 0)
            {
                return Content("Error");
            }
            ViewBag.dept = _departmentRepository.getAll();
            ViewBag.crs = _coursesRepository.getAll();
            Instrauctor Inst = _instructorRepository.getById(id);
            return View(Inst);
        }

        [HttpPost]
        public IActionResult Edit([FromRoute] int id, Instrauctor Inst)
        {
            if (ModelState.IsValid == true)
            {
                _instructorRepository.Update(id, Inst);
                return RedirectToAction("Index");
            }
            ViewBag.dept = _departmentRepository.getAll();
            ViewBag.crs = _coursesRepository.getAll();
            return View("EditFormWithTagHelper",Inst);
           
        }

        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return Content("Not Found");
            }
            _instructorRepository.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult AddWithTagHelper()
        {
            ViewBag.dept = _departmentRepository.getAll();
            ViewBag.crs = _coursesRepository.getAll();
            Instrauctor Inst = new Instrauctor();
            return View(Inst);
        }

        public IActionResult EditFormWithTagHelper(int id)
        {
            if (id == 0)
            {
                return Content("Error");
            }
            ViewBag.dept = _departmentRepository.getAll();
            ViewBag.crs = _coursesRepository.getAll();
            Instrauctor Inst = _instructorRepository.getById(id);
            return View(Inst);
        }

    }
}
