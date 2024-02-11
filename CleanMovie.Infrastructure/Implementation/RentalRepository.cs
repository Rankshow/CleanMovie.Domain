using CleanMovie.Application.Interface;
using CleanMovie.Domain;
using CleanMovie.Infrastructure.Data;

namespace CleanMovie.Infrastructure.Implementation
{
    public class RentalRepository : IRentalRepository
    {
        private readonly MovieDbContext _movieDbContext;
        public RentalRepository(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        public Rental CreateRental(Rental rental)
        {
            _movieDbContext.Rentals.Add(rental);
            _movieDbContext.SaveChanges();
            return rental;
        }

        public List<Rental> GetAllRental()
        {
            return _movieDbContext.Rentals.ToList();
        }
    }
}
