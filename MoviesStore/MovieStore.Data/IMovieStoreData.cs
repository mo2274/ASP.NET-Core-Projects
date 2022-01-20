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
    }
}
