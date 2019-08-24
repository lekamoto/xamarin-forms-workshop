using Newtonsoft.Json;

namespace Xfw.Models
{
    public class Movie
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonIgnore]
        public string FullBackdropPath
            => $"https://image.tmdb.org/t/p/w780{BackdropPath}";

        [JsonIgnore]
        public string FullPosterPath
           => $"https://image.tmdb.org/t/p/w342{PosterPath}";

    }
}
