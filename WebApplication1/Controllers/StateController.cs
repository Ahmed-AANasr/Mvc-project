using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StateController : Controller
    {
         public IActionResult SetState()
        {
            string name = "ITI";
            int Age = 25;
            HttpContext.Session.SetString("SessionName", name);
            return Content("Saved");
        }

        public IActionResult GetState()
        {
            var Name = 
            HttpContext.Session.GetString("SessionName");
            return Content(Name);
        }

    }
}
