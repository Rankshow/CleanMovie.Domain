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

        public Movie CreateMovie(Movie movie)
        {
            _movieRepository.CreateMovie(movie);
            return movie;
        }

        public bool Delete(int movieId)
        {
            var deleteMovie = _movieRepository.Delete(movieId);
            return deleteMovie;
        }

        public List<Movie> GetAllMovies()
        {
            var movies = _movieRepository.GetAllMovies();
            return movies;
        }

        public Movie GetById(int movieId)
        {
            return _movieRepository.GetById(movieId);
        }

        public Movie Update(Movie movie)
        {
            _movieRepository.Update(movie);
            return movie;
        }
    }
}
