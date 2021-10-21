using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApp.Server.Services;
using MovieApp.Shared.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Text.Json;
using System.Threading.Tasks;


namespace MovieApp.Server.Controllers
{
    [Authorize]
    [Route("api/movies")]
    public class MoviesController : ControllerBase
    {
        private readonly ILogger<MoviesController> _logger;
        private readonly IMoviesDbService _dbService;

        public MoviesController(ILogger<MoviesController> logger, IMoviesDbService dbService)
        {
            _logger = logger;
            _dbService = dbService;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            return Ok(await _dbService.GetMovies());
        }

        [HttpDelete("{IdMovie}")]
        public async Task<IActionResult> DeleteMovie(int IdMovie)
        {
            return Ok(await _dbService.DeleteMovie(IdMovie));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateMovie([FromBody] Movie movie)
        {
            return Ok(await _dbService.UpdateMovie(movie));
        }
        [HttpPost]
        public async Task<IActionResult> AddMovie([FromBody] Movie movie)
        {
            return Ok(await _dbService.AddMovie(movie));
        }
    }
}
