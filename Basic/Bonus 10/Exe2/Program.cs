using System;

namespace Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!");
            var num = Console.ReadLine();
         
            if (float.TryParse(num, out float num1Int))
            {
                if (num1Int % 100 == 0)
                {
                    Console.WriteLine("You have entered a cool number!");
                } else 
                {
                    Console.WriteLine("The number you've enterd is not cool at all!");
                } 
            }
            else
            {
                Console.WriteLine("Can't you read? Enter a number, not anything else!");
            }
        }
    }
}
