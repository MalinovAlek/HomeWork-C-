using System;

namespace SwapNumbers
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
                //bool successNum2 = int.TryParse(num2, out int num2Int);
                int num2Int = Convert.ToInt32(num2);
                

                System.Type type = typeof(num2Int);
                Console.WriteLine(type);
                //if (typeof(num2Int) = Int32)
                //{
                //    Console.WriteLine("Number1 is: " + num1Int + " Number2 is " + num2Int);
                //    int temp = num1Int;
                //    num1Int = num2Int;
                //    num2Int = temp;
                //    Console.WriteLine("Number1 now is: " + num1Int + " Number2 now is " + num2Int);
                //}
            }
        }
    }
}
