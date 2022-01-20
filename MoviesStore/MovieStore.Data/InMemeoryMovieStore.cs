using MovieStore.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Data
{
    public class InMemeoryMovieStore : IMovieStoreData
    {
        IEnumerable<Movie> Movies;

        public InMemeoryMovieStore()
        {
            Movies = new List<Movie>()
            {
                new Movie() { Id = 1, Name = "The Shawshank Redemption", Genre = Genre.Drama, Rate = 9.2M,
                              Image = ""},
                new Movie() { Id = 2, Name = "GodFather 1", Genre = Genre.Action, Rate = 9.1M},
                new Movie() { Id = 3, Name = "GodFather 2", Genre = Genre.Action, Rate = 9M},
                new Movie() { Id = 4, Name = "The Dark Knight", Genre = Genre.Fantasy, Rate = 9M},
                new Movie() { Id = 5, Name = "12 Angry Men", Genre = Genre.Drama, Rate = 9M},
                new Movie() { Id = 6, Name = "Schindler's List", Genre = Genre.Drama, Rate = 9M},
            };
        }

        public int Commit()
        {
            return 0;
        }

        public IEnumerable<Movie> GetMovies()
        {
            return Movies;
        }
    }
}
