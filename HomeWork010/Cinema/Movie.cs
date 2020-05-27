using System;
using System.Threading;

namespace Cinema
{
    public class Movie
    {

        static int nextId;
        public int Id { get; private set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }

        public Movie()
        {

        }

        public Movie(string title,Genre genre,int rating)
        {
            Id = Interlocked.Increment(ref nextId);
            Title = title;
            Genre = genre;
          
                if (rating >= 1 && rating <= 5)
                {
                    Rating = rating;
                }
                else {throw new Exception("Set the rating from 1 to 5");}
           

            TicketPrice = 5 * rating;
        }
    }

}
