using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVCApplication.Controllers
{
    public class TAController : Controller
    {
        public IActionResult Index()
        {
            List<string> tas = new List<string>();
            tas.Add("Talia");
            tas.Add("Tim");
            tas.Add("Micah");
            tas.Add("Luke");
            tas.Add("Matt");
            tas.Add("Connor");

            return View(tas);
        }
    }
}
