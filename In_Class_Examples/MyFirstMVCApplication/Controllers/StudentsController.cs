using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVCApplication.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
