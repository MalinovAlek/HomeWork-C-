using System;
using System.Collections.Generic;
using System.Threading;

namespace Cinema
{
    public class Cinema
    {
        static int nextId;
        public int Id { get; private set; }
        public string Name { get; set; }
        public int Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; } = new List<Movie>();

        public Cinema()
        {

        }
        public Cinema(string name,int halls)
        {
            Id = Interlocked.Increment(ref nextId);
            Name = name;
            Halls = halls;
        }
        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"Watching {movie.Title}");
        }
    }
}
