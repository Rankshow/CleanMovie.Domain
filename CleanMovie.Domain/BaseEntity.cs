namespace CleanMovie.Domain
{
    public class BaseEntity 
    {
        public int Id { get; set; } 
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime DateModified { get; set; } = DateTime.UtcNow;
    }
}
