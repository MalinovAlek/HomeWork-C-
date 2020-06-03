using System;

namespace Exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter prob(number)");
            string probCR = Console.ReadLine();
            if (double.TryParse(probCR, out double prob))
            {
                Console.WriteLine("Enter prize(number)");
                string prizeCR = Console.ReadLine();
                if (double.TryParse(prizeCR, out double prize))
                {
                    Console.WriteLine("Enter pay (number)");
                    string payCR = Console.ReadLine();
                    if (double.TryParse(payCR, out double pay))
                    {
                        if (prob * prize > pay)
                        {
                            Console.WriteLine("You won");
                        } else { Console.WriteLine("You lose"); }
                    }
                }
            }
        }
    }
}
