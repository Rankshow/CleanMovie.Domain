using CleanMovie.Application;
using CleanMovie.Domain;


namespace CleanMovie.Infrastructure
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

        public Movie CreateMovie(Movie movie)
        {
            _movieDbContext.Movies.Add(movie);
            _movieDbContext.SaveChanges();
            return movie;
        }

        public bool Delete(int movieId)
        {
            var deleteMovie = _movieDbContext.Movies.FirstOrDefault(x => x.MovieId == movieId);
            _movieDbContext.Remove( deleteMovie ?? new Movie() );
            _movieDbContext.SaveChanges(); 
            return true;
        }

        public List<Movie> GetAllMovies()
        {
            return _movieDbContext.Movies.ToList();
        }

        public Movie GetById(int movieId)
        {
            var getMovie = _movieDbContext.Movies.FirstOrDefault( x => x.MovieId == movieId);
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
