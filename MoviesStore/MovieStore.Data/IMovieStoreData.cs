using MovieStore.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Data
{
    public interface IMovieStoreData
    {
        IEnumerable<Movie> GetMovies();
        int Commit();
        int GetMax();
        IEnumerable<Movie> GetByName(string name);
        Movie GetById(int id);
        Movie Add(Movie movie);
        Movie Update(Movie movie);
        Movie Delete(int id);
    }
}
