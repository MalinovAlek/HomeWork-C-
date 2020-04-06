using System;

namespace Exe10
{
    class Program
    {
        static void Main(string[] args)
        {
            double kelvin = 0;
            double fahrenheit = 0;
            Console.WriteLine("Enter amount of Celsius");
            string celsiusCR = Console.ReadLine();
            if (double.TryParse(celsiusCR, out double celsius))
            {
                kelvin = celsius + 273.15;
                fahrenheit = (celsius * 9 / 5) +32;
                Console.WriteLine("Kelvin = " + kelvin );
                Console.WriteLine("Fahrenheit = " + fahrenheit);
            }
            else { Console.WriteLine("You must enter a number!"); }
        }
    }
}
