using System.Collections.Generic;
using Newtonsoft.Json;

namespace PokedexCollectionViewEN.Models
{
    public class Pokemon
    {
        public int id { get; set; }
        public Name name { get; set; }
        public List<string> type { get; set; }

        [JsonProperty("base")]
        public Base _base { get; set; }

        public string ImageURL
        {
            get
            {
                var num = id.ToString().PadLeft(3, '0');
                return $"https://raw.githubusercontent.com/fanzeyi/pokemon.json/master/images/{num}{name.english}.png";
            }
        }

        public string Types => string.Join(",", type);
    }

    public class Name
    {
        public string english { get; set; }
        public string japanese { get; set; }
        public string chinese { get; set; }
    }

    public class Base
    {
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        [JsonProperty("Sp. Attack")]
        public int SpAttack { get; set; }

        [JsonProperty("Sp. Defense")]
        public int SpDefense { get; set; }

        public int Speed { get; set; }
    }
}
