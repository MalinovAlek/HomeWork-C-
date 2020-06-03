using System;
using System.Globalization;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your birth date by the following order: Year, Month, Day");
            string userDateCR = Console.ReadLine();
            if (DateTime.TryParse(userDateCR, out DateTime dateOfBirth))
            {
                Console.WriteLine(AgeCalcualtor(dateOfBirth));
            }
          
        
        }
        public static string AgeCalcualtor(DateTime birthDate)
        {
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int birthDateUser = int.Parse(birthDate.ToString("yyyyMMdd"));
            int age = (now - birthDateUser) / 10000;
            return  $"You are {age} years old";
            
        }
    }
}
