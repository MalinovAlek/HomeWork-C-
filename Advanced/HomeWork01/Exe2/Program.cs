using System;

namespace Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Create a console application that checks if a day is a working day 🔹
            //The app should request for a user to enter a date as an input or multiple inputs
            //The app should then open and see if the day is a working day
            //It should show the user a message whether the date they entered is working or not
            //Weekends are not working
            //1 January, 7 January, 20 April, 1 May, 25 May, 3 August, 8 September, 12 October, 23 October and 8 December are not working days as well
            //It should ask the user if they want to check another date
            //Yes - the app runs again
            //No - the app closes
            WorkingDays();


        }
        static void WorkingDays()
        {
            Console.WriteLine("Enter Date in the following format(dd/mm/yyyy)");
            DateTime inputDate;
            if (DateTime.TryParse(Console.ReadLine(), out inputDate))
            {
                string date = inputDate.Date.ToString("dd/MM");

                Console.WriteLine(date);

                if (inputDate.DayOfWeek == DayOfWeek.Saturday || inputDate.DayOfWeek == DayOfWeek.Sunday || date == "01-01"
                    || date == "07-01" || date == "20-04" || date == "01-05" || date == "25-05" || date == "03-08" || date == "08-09"
                    || date == "12-10" || date == "23-10" || date == "08-12")
                {
                    Console.WriteLine("It is holliday");
                }
                else { Console.WriteLine("It is a working day"); }

                Console.WriteLine("Do you want to check another date? (Y/N)");
                string anotherDate = Console.ReadLine();
                if (anotherDate.ToUpper() == "Y")
                {
                    WorkingDays();
                }
                else { Console.WriteLine("Goodbye"); }
            }
            else
            {
                Console.WriteLine("You have entered an incorrect value.");
            }
           
        }
        }
}
