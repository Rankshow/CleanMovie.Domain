namespace CleanMovie.Domain
{
    public class BaseEntity
    {
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime DateModified { get; set; }
    }
}
