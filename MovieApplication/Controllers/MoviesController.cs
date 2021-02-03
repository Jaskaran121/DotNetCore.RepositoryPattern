using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApplication.Data;
using MovieApplication.Data.Repositories;
using MovieApplication.Models;

namespace MovieApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieRepository movieRepository;

        public MoviesController (MovieRepository movieRepository){
                this.movieRepository = movieRepository;
        }
        
        // GET: api/<MoviesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovie()
        {
            return await movieRepository.GetAll();
        }

        [HttpPost]
        public async Task<ActionResult<Movie>> PostMovie(Movie movie)
        {
            var result = await movieRepository.Add(movie);
            return Ok();
        }
    }
}
