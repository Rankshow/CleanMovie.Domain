﻿using CleanMovie.Domain;


namespace CleanMovie.Application.Interface
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie Create(Movie movie);
        bool Delete(int movieId);
        Movie GetById(int movieId);
        Movie Update(Movie movie);
    }
}
