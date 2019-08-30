using Newtonsoft.Json;

namespace Xfw.Models
{
    public class Movie
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("tipo")]
        public string tipo { get; set; }

        [JsonProperty("nome")]
        public double nome { get; set; }

        [JsonProperty("desc")]
        public string desc { get; set; }

        [JsonProperty("urlFoto")]
        public string urlFoto { get; set; }



    }

}

