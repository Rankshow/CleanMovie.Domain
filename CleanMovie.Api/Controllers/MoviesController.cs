using CleanMovie.Application.Interface;
using CleanMovie.Domain;
using CleanMovie.Domain.Dto;
using CleanMovie.Domain.Dto.Movies;
using CleanMovie.Domain.Extension;
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
        public ActionResult<GenericResponse<MovieDto>> GetById(int movieId)
        {
            /*var result = new GenericResponse<MovieDto>()
            {
                Code = "200",
                Message = "Success",
                Result = _service.GetById(movieId).MovieToMovieDto();
            }*/
            var addId = _service.GetById(movieId);  
            return Ok(addId);
           
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

       [HttpPut]
        [Route("{movie}")]
        public ActionResult<Movie> Update( Movie movie ) 
        { 
            var movieUpdate = _service.Update( movie );
            return Ok( movieUpdate );
        }
    }
}
