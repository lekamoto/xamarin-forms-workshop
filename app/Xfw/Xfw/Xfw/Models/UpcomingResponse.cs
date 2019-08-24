using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xfw.Models
{
    public class UpcomingResponse
    {
        [JsonProperty("results")]
        public List<Movie> Movies { get; set; }
    }

}
