using CleanMovie.Application.Contract.Dto.Movies;
using CleanMovie.Application.Interface;
using CleanMovie.Domain;


namespace CleanMovie.Application.Implementation
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;          
        }

        public Movie Create(Movie movie)
        {
            _movieRepository.Create(movie);
            return movie;
        }

        public bool Delete(int movieId)
        {
           var deleleteMovie = _movieRepository.Delete(movieId);
            return deleleteMovie;
        }

        public List<Movie> GetAllMovies()
        {
            var allMovies = _movieRepository.GetAll();
            return allMovies;
        }

        public Movie GetById(int movieId)
        {
            return _movieRepository.GetById(movieId);
        }

        public Movie Update(Movie movie)
        {
            return _movieRepository.Update(movie);  
        }
    }
}
