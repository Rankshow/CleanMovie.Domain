namespace CleanMovie.Application.Contract.Dto.Movies
{
    public class MovieDto
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; } = string.Empty;
        public decimal RentalCost { get; set; }
        public int RentalDuration { get; set; }
    }
}
