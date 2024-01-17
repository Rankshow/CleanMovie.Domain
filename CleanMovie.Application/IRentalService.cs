using CleanMovie.Domain;

namespace CleanMovie.Application
{
    public interface IRentalService
    {
        List<Rental> GetAllRental();
        Rental CreateRental( Rental rental );
    }
}
