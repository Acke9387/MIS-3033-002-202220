using Microsoft.AspNetCore.Mvc;
using MVC_Beginner.Models;
using Newtonsoft.Json;

namespace MVC_Beginner.Controllers
{
    public class ChuckController : Controller
    {
        public IActionResult Index()
        {
            ChuckAPI result;
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync("https://api.chucknorris.io/jokes/random").Result;

                result = JsonConvert.DeserializeObject<ChuckAPI>(json);
            }

            return View(result);
        }
    }
}
