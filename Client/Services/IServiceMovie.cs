using System.Collections.Generic;
using Peliculas.Shared.Entity;
namespace Peliculas.Client.Services
{
    public interface IServiceMovie
    {
         List<Movie> GetMovies();
         void AddMovie(Movie nuevaMovie);
    }
}