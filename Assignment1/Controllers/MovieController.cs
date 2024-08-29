using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class MovieController : Controller
    {

       
        public IActionResult GetMovie(int id)
        {
            return Content($"MY ID IS : {id}");
        }
        public IActionResult Redirect()
        {
            return RedirectToAction(nameof(GetMovie),new {id=10});
        }
        public IActionResult Index()
        {
            return Content("My name is Ahmed");
        }
    }
}
