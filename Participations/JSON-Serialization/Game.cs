using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Serialization
{
    public class Game
    {
        public string name { get; set; }
        public string platform { get; set; }
        public DateTime? release_date { get; set; }
        public string summary { get; set; }
        public int meta_score { get; set; }
        public string user_review { get; set; }


        public Game()
        {
            name = string.Empty;
            platform = string.Empty;
            release_date = null;
            summary = string.Empty;
            meta_score = 0;
            user_review = String.Empty;
        }

        public Game(string game)
        {
            var piecesOfGame = game.Split(",");
            //name,platform,release_date,summary,meta_score,user_review

            name = piecesOfGame[0];
            platform = piecesOfGame[1];
            release_date = Convert.ToDateTime(piecesOfGame[2]);
            summary = piecesOfGame[3];
            meta_score = Convert.ToInt32(piecesOfGame[4]);
            user_review = piecesOfGame[5];
        }

        public override string ToString()
        {
            return $"{name} - {platform}";
        }
    }
}
