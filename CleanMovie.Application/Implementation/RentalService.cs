using CleanMovie.Application.Interface;
using CleanMovie.Domain;


namespace CleanMovie.Application.Implementation
{
    public class RentalService : IRentalService
    {
        private readonly IRentalRepository _rentalRepository;
        public RentalService(IRentalRepository rentalRepository)
        {
            _rentalRepository = rentalRepository;
        }
        public Rental CreateRental(Rental rental)
        {
            _rentalRepository.CreateRental(rental);
            return rental;
        }

        public List<Rental> GetAllRental()
        {
            return _rentalRepository.GetAllRental();
        }
    }
}
