namespace CleanMovie.Domain
{
    public class Rental
    {
        public int MemberId { get; set; }     
        public int RentalId { get; set; }   
        public DateTime RentalDate { get; set; }
        public DateTime RentalExpiry { get; set; }
        public decimal TotalCost { get; set; }
        
        //one to many Relationship
        public ICollection<Member> Members { get; set; } = new List<Member>();

        //Many to Many Relation
        public ICollection<MovieRental> MovieRentals { get; set; } = new List<MovieRental>();   
    }
}