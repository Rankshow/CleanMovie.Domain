namespace CleanMovie.Domain.Dto
{
    public class GenericResponse<T>
    {
        public string Code { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public T? Result { get; set; }
    }
}
