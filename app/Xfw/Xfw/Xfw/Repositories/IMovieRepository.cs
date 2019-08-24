using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xfw.Models;

namespace Xfw.Repositories
{
    public interface IMovieRepository
    {
        Task<(string error, List<Movie>)> GetUpcoming();
    }
}
