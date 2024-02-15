using CleanMovie.Application.Contract.Dto.Movies;
using CleanMovie.Domain;

namespace CleanMovie.Application.Contract.Extension
{
    public static class MovieExtension
    {
        public static Movie AsEntity(this CreateMovieRequest req)
        {
            return new Movie()
            {
                MovieName = req.MovieName,
                RentalCost = req.RentalCost,
                RentalDuration = req.RentalDuration,
                CreatedBy = "Obinna",
                DateCreated = DateTime.Now.AddDays(-15),
                ModifiedBy = "Admin",
                DateModified = DateTime.Now,    
            };
        }
        public static MovieDto AsDto(this Movie dto)
        {
            return new MovieDto()
            {
                MovieName = dto.MovieName,
                RentalCost = dto.RentalCost,
                RentalDuration = dto.RentalDuration,
            };
        }
        public static List<MovieDto> AsDto(this List<Movie> entities)
        {
            var movieDtos = new List<MovieDto>();
            foreach (Movie entity in entities)
            {
                movieDtos.Add(entity.AsDto());
            }
            return movieDtos;
        }
       // public static Entit

    }
}
