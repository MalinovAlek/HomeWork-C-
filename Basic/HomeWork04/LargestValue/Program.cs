using System;

namespace LargestValue
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double[] numbers = new double[] { 1, 2, 8, 3, 4, 5, 3, 0.5, 9.8, -2 };
            Console.WriteLine(LargestValue(numbers));
        }
        public static double LargestValue(double[] arr)
        {
            double num = -1.7976931348623157E+308;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > num)
                {
                    num = arr[i];
                  
                };
            
            }
            return num;
        }
    }
}
