using Microsoft.EntityFrameworkCore;
using MovieApp.Server.Data;
using MovieApp.Shared.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Server.Services
{
    public interface IMoviesRepository
    {

    }

    public interface IMoviesDbService
    {
        public Task<List<Movie>> GetMovies();
        public Task AddMovie();
        public Task<Movie> GetMovie(int movieId);
        public Task<string> DeleteMovie(int IdMovie);
        public Task<Movie> UpdateMovie(Movie movie);
        public Task<Movie> AddMovie(Movie movie);
    }

    public class MoviesDbService : IMoviesDbService
    {
        private ApplicationDbContext _context;

        public MoviesDbService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddMovie()
        {
            throw new System.NotImplementedException();
        }

        public Task<Movie> GetMovie(int movieId)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Movie>> GetMovies()
        {
            return _context.Movies.OrderBy(m => m.Title).ToListAsync();
        }
        public async Task<string> DeleteMovie(int IdMovie)
        {
            Movie movie = await _context.Movies.SingleOrDefaultAsync(d => d.Id == IdMovie);
            _context.Movies.Attach(movie);
            _context.Entry(movie).State = EntityState.Deleted;
            await _context.SaveChangesAsync(); 

            return "movie is deleted";
        }
        public async Task<Movie> UpdateMovie(Movie movie)
        {
            if (movie==null)
            {
                return null;
            }
            Movie NewMovie = new Movie
            {
                Id= movie.Id,
                Title=movie.Title,
                Summary=movie.Summary,
                InTheaters=movie.InTheaters,
                Trailer=movie.Trailer,
                ReleaseDate=movie.ReleaseDate,
                Poster=movie.Poster
            };
            _context.Movies.Attach(NewMovie);
            if (movie.Title!=null) {
                _context.Entry(NewMovie).Property("Title").IsModified = true;
            }
            if (movie.Summary != null)
            {
                _context.Entry(NewMovie).Property("Summary").IsModified = true;
            }
            if (movie.InTheaters != null)
            {
                _context.Entry(NewMovie).Property("InTheaters").IsModified = true;
            }
            if (movie.Trailer!=null) {
                _context.Entry(NewMovie).Property("Trailer").IsModified = true;
            }
            if (movie.ReleaseDate!=null) {
                _context.Entry(NewMovie).Property("ReleaseDate").IsModified = true;
            }
            if (movie.Poster != null)
            {
                _context.Entry(NewMovie).Property("Poster").IsModified = true;
            }
            await _context.SaveChangesAsync();
            return NewMovie;
        }
        public async Task<Movie> AddMovie(Movie movie)
        {
            if (movie==null)
            {
                return null;
            }
            Movie NewMovie = new Movie
            {
                Id = movie.Id,
                Title = movie.Title,
                Summary = movie.Summary,
                InTheaters = movie.InTheaters,
                Trailer = movie.Trailer,
                ReleaseDate = movie.ReleaseDate,
                Poster = movie.Poster
            };
            _context.Movies.Add(NewMovie);
            await _context.SaveChangesAsync();

            return NewMovie;
        }
    }
}
