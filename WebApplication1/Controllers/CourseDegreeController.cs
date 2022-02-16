using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class CourseDegreeController : Controller
    {
        DBRelations context = new DBRelations();
        public IActionResult ShowTraineeDegree(int id)
        {
            Trainee trainee =
                context.Trainee.Include(t => t.crs).FirstOrDefault(t => t.ID == id);

            var traineeDegreeCourse =
                context.courseResult.FirstOrDefault(cd=>cd.train_id == id && cd.crs_id ==trainee.crs_id );

            CoursesDegreeVM traineeCoursesDegreeVM = new CoursesDegreeVM();

            traineeCoursesDegreeVM.Name = trainee.Name;
            traineeCoursesDegreeVM.ID = trainee.ID;
            traineeCoursesDegreeVM.CourseDegree = traineeDegreeCourse.Degree;

            if (trainee.crs.MinDegree <= traineeDegreeCourse.Degree)
            {
                traineeCoursesDegreeVM.color = "green";
            }else
            {
                traineeCoursesDegreeVM.color = "red";
            }

            return View(traineeCoursesDegreeVM);
        }
    }
}
