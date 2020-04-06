using System;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 'true' or 'false'");
            string trueOrFalse = Console.ReadLine();
            if (trueOrFalse == "true")
            {
                trueOrFalse = "false";
            } else if(trueOrFalse == "false")
            {
                trueOrFalse = "true";
            } else
            {
                trueOrFalse = "Error";
            }
            Console.WriteLine(trueOrFalse);
        }
    }
}
