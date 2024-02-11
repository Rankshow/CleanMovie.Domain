using System.ComponentModel.DataAnnotations;


namespace CleanMovie.Domain.Dto.Movies
{
    public class CreateMovieRequest
    {
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string MovieName { get; set; } = string.Empty;
        [Required]
        public decimal RentalCost { get; set; }
        [Required]
        public int RentalDuration { get; set; }
    }
}
