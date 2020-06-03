using System;

namespace Exe9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 6);
            switch (num)
            {
                case 1:
                    Console.WriteLine("You got a jackpot 1.000.000EUR");
                    break;
                case 2:
                    Console.WriteLine("You will lose weights");
                    break;
                case 3:
                    Console.WriteLine("Your boyfriend will break up with you!");
                    break;
                case 4:
                    Console.WriteLine("Your cousine will buy you a dog!");
                    break;
                case 5:
                    Console.WriteLine("You will leave 100 years!");
                    break;
                default:
                    Console.WriteLine("Error, incorrect value");
                    break;
            }
        }
    }
}
