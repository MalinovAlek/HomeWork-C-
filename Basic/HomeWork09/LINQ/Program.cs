using System;
using Models;
using System.Linq;
using System.Collections.Generic;


namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = SongHelper.GetAllSongs();
            var fans = PersonHelper.GetAllFans();

            //Select the person Jerry and add all the songs which start with the letter B
            List<Song> songsStartingWithB = songs.Where(song => song.Title.StartsWith("B")).ToList();
            fans.Where(fan => fan.FirstName == "Jerry").Select(fan => fan.FavouriteSongs = songsStartingWithB).ToList();

            //Select the person Maria and add all the songs with length longer than 6 mins
            List<Song> songsLongerThan6 = songs.Where(song => song.Length > 360).ToList();
            fans.Where(fan => fan.FirstName == "Maria").Select(fan => fan.FavouriteSongs = songsLongerThan6).ToList();

            //Select the person Jane and add all the songs that are of genre Rock
            List<Song> rockSongs = songs.Where(song => song.Genre == Genre.Rock).ToList();
            fans.Where(fan => fan.FirstName == "Jane").Select(fan => fan.FavouriteSongs = rockSongs).ToList();

            //Select the person Stefan and add all songs shorter than 3 mins and of genre Hip - Hop
            List<Song> hipHopShorterThan3 = songs.Where(song => song.Genre == Genre.Hip_Hop && song.Length < 180).ToList();
            fans.Where(fan => fan.FirstName == "Stefan").Select(fan => fan.FavouriteSongs = hipHopShorterThan3).ToList();

            //Select all persons from the persons array that have 4 or more songs

            List<Person> fansWithMoreThan4Songs = fans.Where(fan => fan.FavouriteSongs.Count >= 4).ToList();

            foreach (var item in fansWithMoreThan4Songs)
            {
                Console.WriteLine(item.FirstName);
            }

            Person jane = fans.FirstOrDefault(x => x.FirstName == "Jane");
            Person stefan = fans.FirstOrDefault(x => x.Id == 2);
            Person maria = fans.FirstOrDefault(x => x.Age == 43);

            jane.GetFavSong();
            Console.WriteLine("---------------------------------");
            stefan.GetFavSong();
            Console.WriteLine("---------------------------------");
            maria.GetFavSong();
        }
      
    }
}
