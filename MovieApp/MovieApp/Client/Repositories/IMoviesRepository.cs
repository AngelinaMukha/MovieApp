using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Shared.Models;

namespace MovieApp.Client.Repositories
{
    public interface IMoviesRepository
    {
        Task<List<Movie>> GetMovies();
        Task<Movie> GetDetailsMovieDTO(int id);
        Task<int> CreateMovie(Movie movie);
        Task DeleteMovie(int id);
        Task UpdateMovie(Movie movie);
    }
}
