using AutoMapper;
using CleanMovie.Application.Contract.Dto.Movies;
using CleanMovie.Domain;

namespace CleanMovie.Application.Profiles
{
    public class MovieProfiles : Profile
    {
        public MovieProfiles()
        {
            //source --> destination
            CreateMap<Movie, MovieDto>();

            CreateMap<CreateMovieDto, Movie>();

            CreateMap<UpdateCreateDto, Movie>();
        }
    }
}
