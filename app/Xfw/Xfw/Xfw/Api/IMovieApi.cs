using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xfw.Models;

namespace Xfw.Api
{
    public interface IMovieApi
    {
        [Get("/movie/upcoming?api_key={apiKey}")]
        Task<UpcomingResponse> GetUpcoming(string apiKey);
    }
}
