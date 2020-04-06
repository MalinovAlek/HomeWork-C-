using System;

namespace Exe5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of chickens");
            var chickensCR = Console.ReadLine();
            if (int.TryParse(chickensCR, out int chickens) )
            {
                int chickenLegs = chickens * 2;
                Console.WriteLine("Enter number of cows");
                var cowsCR = Console.ReadLine();
                if (int.TryParse(cowsCR, out int cows))
                {
                    int cowLegs = cows * 4;
                    Console.WriteLine("Enter number of pigs");
                    var pigsCR = Console.ReadLine();
                    if (int.TryParse(pigsCR, out int pigs))
                    {
                        int pigLegs = pigs * 4;
                        Console.WriteLine("Total animal legs: " + (chickenLegs + cowLegs + pigLegs));
                    }
                    else
                    {
                        Console.WriteLine("Enter a number");
                    }
                } else
                {
                    Console.WriteLine("Enter a number");
                }
            } else
            {
                Console.WriteLine("Enter a number");
            }
            
        }
    }
}
