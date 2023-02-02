using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_RickAndMorty
{
    public class RickAndMortyAPI
    {

        public Information info { get; set; }

        public List<ResultItem> results { get; set; }
    }

    public class ResultItem
    {
        public int id { get; set; }

        public string name { get; set; }

        public string image { get; set; }

        public string url { get; set; }

        public override string ToString()
        {
            return name;
        }
    }

    public class Information
    {
        public int count { get; set; }

        public int pages { get; set; }

        public string next { get; set; }

        public string prev { get; set; }

    }
}
