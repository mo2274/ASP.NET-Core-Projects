using MovieStore.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MovieStore.Data
{
    public class InMemeoryMovieStore : IMovieStoreData
    {
        List<Movie> Movies;

        public InMemeoryMovieStore()
        {
            Movies = new List<Movie>()
            {
                new Movie() { Id = 1, Name = "The Shawshank Redemption", Genre = Genre.Drama, Rate = 9.2M,
                              ImageLink = "Shawshank.jpg"},
                new Movie() { Id = 2, Name = "The GodFather 1", Genre = Genre.Action, Rate = 9.1M,
                              ImageLink = "The GodFather.jfif"},
                new Movie() { Id = 3, Name = "The GodFather 2", Genre = Genre.Action, Rate = 9M,
                              ImageLink = "TheGodFather2.jfif"},
                new Movie() { Id = 4, Name = "The Dark Knight", Genre = Genre.Fantasy, Rate = 9M,
                              ImageLink = "The Dark Night.jfif"},
                new Movie() { Id = 5, Name = "12 Angry Men", Genre = Genre.Drama, Rate = 9M,
                              ImageLink = "12 Angry Men.jfif"},
                new Movie() { Id = 6, Name = "Schindler's List", Genre = Genre.Drama, Rate = 9M,
                              ImageLink = "Schindler's List.jfif"},
            };
        }

        public Movie Add(Movie movie)
        {
            var id = Movies.Max(m => m.Id) + 1;
            movie.Id = id;
            Movies.Add(movie);
            return movie;
        }

        public int Commit()
        {
            return 0;
        }

        public Movie Delete(int id)
        {
            var Movie = GetById(id);

            if (Movie == null)
                return null;

            Movies.Remove(Movie);

            return Movie;
        }

        public Movie GetById(int id)
        {
            return Movies.SingleOrDefault(m => m.Id == id);
        }

        public IEnumerable<Movie> GetByName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return Movies;

            var movies =  Movies.Where(m =>  m.Name.ToLower().Contains(name.ToLower()));
            return movies;
        }

        public int GetMax()
        {
            return Movies.Max(m => m.Id);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return Movies;
        }

        public Movie Update(Movie movie)
        {
            var oldMovie = GetById(movie.Id);
            if (oldMovie == null)
                return null;

            oldMovie.Name = movie.Name;
            oldMovie.Rate = movie.Rate;
            oldMovie.Genre = movie.Genre;
            oldMovie.ImageLink = movie.ImageLink;

            return movie;
        }
    }
}
