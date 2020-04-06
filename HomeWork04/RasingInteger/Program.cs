using System;

namespace RasingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string numCR = Console.ReadLine();
            if (int.TryParse(numCR, out int num))
            {
                Console.WriteLine("Enter how many times to raise the first number");
                string raiserCR = Console.ReadLine();
                if (int.TryParse(raiserCR, out int raiser))
                {
                    Console.WriteLine(RaiseInteger(num,raiser));
                }
            }
        }
        public static string RaiseInteger(int num, int raiser)
        {

            int result = 1;

            for (int i = 0; i < raiser; i++)
            {
                result = result * num;
            }

            return $"{num} raise to {raiser} = {result}";
        }
    }
}
