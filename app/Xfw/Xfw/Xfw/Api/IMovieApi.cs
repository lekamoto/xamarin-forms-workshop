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
        [Get("")]
        Task<UpcomingResponse> GetUpcoming();
    }

}
