using CleanMovie.Domain;

namespace CleanMovie.Application.Interface
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        Movie CreateMovie(Movie movie);
        bool Delete(int movieId);
        Movie GetById(int movieId);
        Movie Update(Movie movie);
    }
}
