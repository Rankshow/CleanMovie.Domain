using CleanMovie.Application.Contract.Dto.Movies;
using CleanMovie.Application.Contract.Extension;
using CleanMovie.Application.Interface;
using CleanMovie.Domain;
using CleanMovie.Infrastructure.Data;

namespace CleanMovie.Infrastructure.Implementation
{
    public class MovieRepository : IMovieRepository 
    {
        /*public static List<Movie> movies = new List<Movie>()
        {
            new Movie{Id = 1, Name = "Tribe of judah", Cost = 3},
            new Movie{Id = 2, Name = "Home alone", Cost = 4}
        };*/
        private readonly MovieDbContext _movieDbContext;

        public MovieRepository(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        public Movie Create(Movie movie)
        {
            _movieDbContext.Add(movie);
            _movieDbContext.SaveChanges();
            return movie;   
        }

        public bool Delete(int movieId)
        {
            var deleteMovie = _movieDbContext.Movies.Where(p => p.MovieId == movieId);
            _movieDbContext.Remove(deleteMovie);
            return true;
        }

        public List<Movie> GetAll()
        {
            return _movieDbContext.Movies.ToList();
        }

        public Movie GetById(int movieId)
        {
            var getMovie = _movieDbContext.Movies.FirstOrDefault( p => p.MovieId == movieId);
            _movieDbContext.SaveChanges();
            return getMovie ?? new Movie();
        }

        public Movie Update(Movie movie)
        {
            var updateMovie = _movieDbContext.Movies.FirstOrDefault(x => x.Equals(movie));
            _movieDbContext.Update(movie);
            return updateMovie ?? new Movie();
        }
    }
}
