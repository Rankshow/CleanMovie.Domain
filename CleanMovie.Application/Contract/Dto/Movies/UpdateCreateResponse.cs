namespace CleanMovie.Application.Contract.Dto.Movies
{
    public class UpdateCreateResponse<T> : BaseResponse
    {
        public T? Result { get; set; }
    }
}
