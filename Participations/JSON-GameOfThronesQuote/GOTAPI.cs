using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_GameOfThronesQuote
{
    public class GOTAPI
    {

        public string sentence { get; set; }

        public Character character { get; set; }


    }

    public class Character
    {
        public string name { get; set; }

        public string slug { get; set; }

        public House house { get; set; }

    }

    public class House
    {
        public string name { get; set; }

        public string slug { get; set; }
    }
}


