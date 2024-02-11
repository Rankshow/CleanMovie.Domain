using CleanMovie.Domain;

namespace CleanMovie.Application.Interface
{
    public interface IRentalService
    {
        List<Rental> GetAllRental();
        Rental CreateRental(Rental rental);
    }
}
