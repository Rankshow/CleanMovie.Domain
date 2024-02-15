namespace CleanMovie.Domain
{
    public class Movie : BaseEntity
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; } = string.Empty;
        public decimal RentalCost { get; set; }
        public int RentalDuration { get; set; }

        //Many to Many relation
        public ICollection<MovieRental>? MovieRentals { get; set; } 
    }
}
