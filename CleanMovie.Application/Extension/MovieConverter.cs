using CleanMovie.Domain.Dto.Movies;


namespace CleanMovie.Domain.Extension
{
    public static class MovieConverter
    {
        public static MovieDto MovieToMovieDto(
            this Movie movie)
        {
            return new MovieDto ()
            {
                MovieName = movie.MovieName,
                RentalCost = movie.RentalCost,
                RentalDuration = movie.RentalDuration
            };
        }
    }
}
