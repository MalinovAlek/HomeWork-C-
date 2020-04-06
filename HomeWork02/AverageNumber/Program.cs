using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            string num1 = Console.ReadLine();
            bool successNum1 = float.TryParse(num1, out float num1Int);
            if (successNum1)
            {
                Console.WriteLine("Enter Number");
                string num2 = Console.ReadLine();
                bool successNum2 = float.TryParse(num2, out float num2Int);
                if (successNum2)
                {
                    Console.WriteLine("Enter Number");
                    string num3 = Console.ReadLine();
                    bool successNum3 = float.TryParse(num3, out float num3Int);
                    if (successNum3)
                    {
                        Console.WriteLine("Enter Number");
                        string num4 = Console.ReadLine();
                        bool successNum4 = float.TryParse(num4, out float num4Int);

                        if (successNum4)
                        {
                            float result = (num1Int + num2Int + num3Int + num4Int) / 4;
                            Console.Write("Final result is:");
                            Console.WriteLine(result);
                        }
                    }
                   
                }
            }
        }
    }
}
