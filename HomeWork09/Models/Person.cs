using System;
using System.Collections.Generic;
using System.Threading;

namespace Models
{
    public class Person
    {
        static int nextId;
        public int Id { get; private set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre MusicType { get; set; }
        public List<Song> FavouriteSongs { get; set; } = new List<Song>();

        public Person(string firstname,string lastname, int age, Genre genre)
        {
            Id = Interlocked.Increment(ref nextId);
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            MusicType = genre;
        }
        public void GetFavSong()
        {
            if (FavouriteSongs.Count < 1)
            {
                Console.WriteLine("This person hates music");
            }
            else
            {
                foreach (var item in FavouriteSongs)
                {
                    Console.WriteLine(item.Title);
                }  
            }
            
        }

    }
    }


