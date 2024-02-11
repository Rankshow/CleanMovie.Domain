using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application.Interface
{
    public interface IRentalRepository
    {
        List<Rental> GetAllRental();
        Rental CreateRental(Rental rental);
    }
}
