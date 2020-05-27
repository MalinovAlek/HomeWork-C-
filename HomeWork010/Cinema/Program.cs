using System;
using System.Collections.Generic;
using System.Linq;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cinema> allCinemas = CinemaHelper.GetAllCinemas();
            Console.WriteLine("Chose a Cinema:");
            for (int i = 0; i < allCinemas.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{allCinemas[i].Name}");
            }
            string choseCinemaCR = Console.ReadLine();

            try
            {
                int choseCinema = Int32.Parse(choseCinemaCR);
                if (choseCinema > allCinemas.Count || choseCinema < 1)
                {
                    throw new Exception($"You must a number from 1 to {allCinemas.Count}");
                }
                Cinema userCinema = GetCinema(choseCinema, allCinemas);

                Console.WriteLine($"You chose {userCinema.Name}");

                Console.WriteLine("Would you like to see:\n 1. All Movies\n 2. By genre");
                string userAllOrGenre = Console.ReadLine();
                AllMoviesOrGenre(userAllOrGenre, userCinema);
            }

            catch (FormatException)
            {
                Console.WriteLine($"You must enter proper number ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
        }

        public static Cinema GetCinema(int cinemaNum, List<Cinema> cinemas)
        {
            Cinema cinema = cinemas.ElementAt(cinemaNum - 1);
            return cinema;
        }

        public static void AllMoviesOrGenre(string input, Cinema userCinema)
        {
            if (input == "1") { AllMOvies(userCinema); }
            else if (input == "2")
            {
                List<Movie> genreList = GetGenreList(userCinema);
                if (genreList.Count < 1)
                {
                    throw new Exception($"Enter a number from 1 to 5");
                }
                else { GetMoviesByGenre(userCinema, genreList); }
                
            }
            else { Console.WriteLine($"You must enter 1 or 2"); }
        }

        public static void AllMOvies(Cinema userCinema)
        {

            Console.WriteLine("Chose a movie by number:");

            for (int i = 0; i < userCinema.ListOfMovies.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{userCinema.ListOfMovies[i].Title}");
            }

            string userMovieCR = Console.ReadLine();
            try
            {
                int userMovieId = Int32.Parse(userMovieCR);
                if (userMovieId > userCinema.ListOfMovies.Count || userMovieId < 1)
                {
                    throw new Exception($"You must a number from 1 to {userCinema.ListOfMovies.Count}");
                }
                userCinema.MoviePlaying(userCinema.ListOfMovies.ElementAt(userMovieId - 1));
            }
            catch (FormatException)
            {
                Console.WriteLine($"You can't enter text");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public static List<Movie> GetGenreList(Cinema userCinema)
        {
            Console.WriteLine("Enter your favourite Genre: \n1.Comedy \n2.Horror \n3.Action \n4.Drama \n5.Sci-Fi");
            string userGenreCR = Console.ReadLine();
            List<Movie> listByGenre = new List<Movie>();

            try
            {
                int userGenre = Int32.Parse(userGenreCR);
                //if (userGenre < 1 || userGenre > 5) 
                //{

                //}
                switch (userGenre)
                {

                    case 1:
                        listByGenre = userCinema.ListOfMovies.Where(x => x.Genre == Genre.Comedy).ToList();
                        break;
                    case 2:
                        listByGenre = userCinema.ListOfMovies.Where(x => x.Genre == Genre.Horror).ToList();
                        break;
                    case 3:
                        listByGenre = userCinema.ListOfMovies.Where(x => x.Genre == Genre.Action).ToList();
                        break;
                    case 4:
                        listByGenre = userCinema.ListOfMovies.Where(x => x.Genre == Genre.Drama).ToList();
                        break;
                    case 5:
                        listByGenre = userCinema.ListOfMovies.Where(x => x.Genre == Genre.SciFi).ToList();
                        break;

                        
                }
                
            }
            catch (FormatException)
            {
                throw new Exception($"You can't enter text");
            }


            return listByGenre;
        }

        public static void GetMoviesByGenre(Cinema userCinema, List<Movie> genreList)
        {
            Console.WriteLine($"Chose a movie:");
            for (int i = 0; i < genreList.Count; i++)
            {
                Console.WriteLine($"{i+1}.{genreList[i].Title}");
            }
            string userMovieCR = Console.ReadLine();
            try
            {
                int userMovieId = Int32.Parse(userMovieCR);
                if (userMovieId > genreList.Count || userMovieId < 1)
                {
                    throw new Exception($"You must enter a number from 1 to {genreList.Count}");
                }
                userCinema.MoviePlaying(genreList.ElementAt(userMovieId - 1));
            }
            catch (FormatException)
            {
                Console.WriteLine($"A number must be entered!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
