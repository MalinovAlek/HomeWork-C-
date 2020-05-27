using System;
using System.Collections.Generic;

namespace Cinema
{
    public class CinemaHelper
    {
        public static List<Cinema> GetAllCinemas()
        {
           
                Movie movie1 = new Movie("Lord of the rings", Genre.Action, 5);
                Movie movie2 = new Movie("Psycho", Genre.Horror, 4);
                Movie movie3 = new Movie("The Shining", Genre.Horror, 4);
                Movie movie4 = new Movie("Interstellar", Genre.SciFi, 5);
                Movie movie5 = new Movie("The Matrix", Genre.SciFi, 5);
                Movie movie6 = new Movie("The Wolf of Wall Street", Genre.Drama, 5);
                Movie movie7 = new Movie("21 jump street", Genre.Comedy, 4);
                Movie movie8 = new Movie("Date Movie", Genre.Comedy, 1);
                Movie movie9 = new Movie("Scary Movie", Genre.Comedy, 3);
                Movie movie10 = new Movie("Death Curse of Tartu", Genre.Horror, 2);
                Movie movie11 = new Movie("Evil Spawn ", Genre.Horror, 2);
                Movie movie12 = new Movie("The Avengers  ", Genre.Action, 5);

                List<Movie> allMovies = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10, movie11, movie12 };

                Cinema cineplex = new Cinema("Cineplex", 8);
                cineplex.ListOfMovies = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie9, movie11, movie12 };

                Cinema mileniium = new Cinema("Milenieum", 2);
                mileniium.ListOfMovies = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie10, movie12 };

                Cinema cinOM = new Cinema("Cinematheque of Macedonia", 3);
                cinOM.ListOfMovies = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };

                List<Cinema> allCinemas = new List<Cinema>() { cineplex, mileniium, cinOM };



                return allCinemas;


        }
    }
}
