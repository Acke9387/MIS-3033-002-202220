using Microsoft.AspNetCore.Mvc;
using MVC_Beginner.Models;
using Newtonsoft.Json;

namespace MVC_Beginner.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            PokeAPI result;
            using (var client = new HttpClient())
            {
                string url = "https://pokeapi.co/api/v2/pokemon?offset=0&limit=1300";
                string json = client.GetStringAsync(url).Result;

                result = JsonConvert.DeserializeObject<PokeAPI>(json);
            }

            return View(result.results);
        }

        public IActionResult Info(string id)
        {
            PokemonInfo result;
            using (var client = new HttpClient())
            {
                string url = $"https://pokeapi.co/api/v2/pokemon/{id}";
                string json = client.GetStringAsync(url).Result;

                result = JsonConvert.DeserializeObject<PokemonInfo>(json);
            }

            return View(result);
        }
    }
}
