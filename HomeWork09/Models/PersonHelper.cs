using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class PersonHelper
    {
        public static List<Person> GetAllFans() 
        {
            List<Person> FansArray = new List<Person>();
            //fans
            Person Jerry = new Person("Jerry", "Tompson", 78, Genre.Rock);
            Person Stefan = new Person("Stefan", "Stefanoski", 28, Genre.Techno);
            Person Maria = new Person("Maria", "Campbel", 43, Genre.Classical);
            Person Jane = new Person("Jane", "Doe", 28, Genre.Techno);

            

            FansArray.Add(Jerry);
            FansArray.Add(Stefan);
            FansArray.Add(Maria);
            FansArray.Add(Jane);

            return FansArray;
        }
    }
}
