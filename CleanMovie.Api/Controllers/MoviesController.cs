using CleanMovie.Application;
using CleanMovie.Domain;
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

        [HttpPost]
        public ActionResult<Movie> PostMovie( Movie movie ) 
        {
            var addMovie = _service.CreateMovie( movie );
            return Ok( addMovie );
        }

        [HttpDelete]
        [Route("{movieId:int}")]
        public ActionResult<bool> DeleteMovie( int movieId ) 
        { 
            _service.Delete( movieId );
            return Ok( true );  
        }

        [HttpGet]
        [Route("{movieId}")]
        public ActionResult<Movie> GetById( int movieId ) 
        { 
            var getMovieId = _service.GetById( movieId );
            return Ok( getMovieId );   
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
