using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            string num1 = Console.ReadLine();
            bool successNum1 = int.TryParse(num1, out int num1Int);

            if (successNum1)
            {
                Console.WriteLine("Enter Number");
                string num2 = Console.ReadLine();
                bool successNum2 = int.TryParse(num2, out int num2Int);

                if (successNum2)
                {
                    Console.WriteLine("Enter Operator: +,-,*,/ ");
                    string operation = Console.ReadLine();
                    switch (operation)
                    {
                        case "+":
                            Console.WriteLine("Result is " + (num1Int + num2Int));
                            break;
                        case "-":
                            Console.WriteLine("Result is " + (num1Int - num2Int));
                            break;
                        case "*":
                            Console.WriteLine("Result is " + (num1Int * num2Int));
                            break;
                        case "/":
                            Console.WriteLine("Result is " + (num1Int / num2Int));
                            break;
                        default:
                            Console.WriteLine("Wrong Input");
                            break;
                    }
                }
            }
        }
    }
}
