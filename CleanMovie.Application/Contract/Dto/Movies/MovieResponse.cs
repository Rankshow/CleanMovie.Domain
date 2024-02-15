using System.ComponentModel.DataAnnotations;

namespace CleanMovie.Application.Contract.Dto.Movies
{
    public class MovieResponse<T> : BaseResponse
    {
        public T? Result { get; set; }
    }
}
