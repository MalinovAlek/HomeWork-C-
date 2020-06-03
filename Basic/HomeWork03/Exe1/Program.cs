using System;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];
            Console.WriteLine("Enter number 1");
            string num1CR = Console.ReadLine();
            if (int.TryParse(num1CR, out numbers[0]))
            {
                Console.WriteLine("Enter number 2");
                string num2CR = Console.ReadLine();
                if (int.TryParse(num2CR, out numbers[1]))
                {
                    Console.WriteLine("Enter number 3");
                    string num3CR = Console.ReadLine();
                    if (int.TryParse(num3CR, out numbers[2]))
                    {
                        Console.WriteLine("Enter number 4");
                        string num4CR = Console.ReadLine();
                        if (int.TryParse(num4CR, out numbers[3]))
                        {
                            Console.WriteLine("Enter number 5");
                            string num5CR = Console.ReadLine();
                            if (int.TryParse(num5CR, out numbers[4]))
                            {
                                Console.WriteLine("Enter number 6");
                                string num6CR = Console.ReadLine();
                                if (int.TryParse(num6CR, out numbers[5]))
                                {
                                    int sum = 0;
                                    for (int i = 0; i < numbers.Length; i++)
                                    {
                                        if (numbers[i] % 2 == 0)
                                        {
                                          
                                            sum += numbers[i];
                                          
                                              
                                        }
                                    }
                                    Console.WriteLine("Sum of even numbers is " + sum);
                                }
                            }
                        }
                    }
                }
            }
            else { Console.WriteLine("You must enter a number"); }
        } 
    }
}
