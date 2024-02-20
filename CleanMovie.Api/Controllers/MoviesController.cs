using AutoMapper;
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
        private readonly IMapper _mapper;

        public MoviesController(IMovieService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<MovieDto>> GetAllMovies()
        { 
            var allMovies = _service.GetAllMovies();
            
            var allDto = _mapper.Map<List<MovieDto>>(allMovies);
            return Ok(allDto);
        }

        [HttpGet]
        [Route("{movieId}")]
        public ActionResult<MovieDto> GetById(int movieId)
        {
            var addId = _service.GetById(movieId);

            var addDto = _mapper.Map<MovieDto>(addId);
            return Ok(addDto);
        }
      
        [HttpPost]
        public ActionResult<MovieDto> Create([FromBody] CreateMovieDto movie ) 
        {
            //Map movieDto to movie
            var addMovie = _mapper.Map<Movie>(movie);

            //created movie
            var createdMov = _service.Create( addMovie );

            //Map movie to read dto
            var movieReadDto = _mapper.Map<MovieDto>(createdMov);
            return Ok(movieReadDto);
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
        public ActionResult<MovieDto> Update([FromBody]UpdateCreateDto movie ) 
        { 
            //Map movieDto to movie
            var movieUpdate = _mapper.Map<Movie>(movie);

            //Update movie
            var updatedMovie = _service.Update(movieUpdate);

            //Movie movie to read dto
            var updateReaDto = _mapper.Map<MovieDto>(updatedMovie);
            return Ok(updateReaDto);
        }
    }
}
