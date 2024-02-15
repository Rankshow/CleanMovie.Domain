using CleanMovie.Application.Contract.Dto;
using CleanMovie.Application.Contract.Dto.Movies;
using CleanMovie.Application.Interface;
using CleanMovie.Domain;
//using CleanMovie.Domain.Extension;
using Microsoft.AspNetCore.Mvc;


namespace CleanMovie.Api.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _service;

        public MoviesController(IMovieService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Movie>> GetAllMovies()
        { 
            var moviesFromService = _service.GetAllMovies();
            return Ok(moviesFromService);
        }

        [HttpGet]
        [Route("{movieId}")]
        public ActionResult<Movie> GetById(int movieId)
        {
            var addId = _service.GetById(movieId);  
            return Ok(addId);
           
        }
      
        [HttpPost]
        public ActionResult<Movie> Create( Movie movie ) 
        {
            var addMovie = _service.Create( movie );
            return Ok( addMovie );
        }

        [HttpDelete]
        [Route("{movieId:int}")]
        public ActionResult<bool> DeleteMovie( int movieId ) 
        { 
            _service.Delete( movieId );
            return Ok( true );  
        }

       [HttpPut]
       [Route("{movie}")]
        public ActionResult<Movie> Update( Movie movie ) 
        { 
            var movieUpdate = _service.Update( movie );
            return Ok( movieUpdate );
        }
    }
}
