namespace MVC_Beginner.Models
{
    public class PokeAPI
    {
        public List<Pokemon> results { get; set; }
    }

    public class Pokemon
    {
        public string name { get; set; }

        public string url { get; set; }
    }
}
