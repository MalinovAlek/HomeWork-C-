using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Substring();
            Console.WriteLine("Enter a number");
            string nCR = Console.ReadLine();
            if (int.TryParse(nCR, out int num) && num <= sentence.Length)
            {
                string newSentence = sentence.Substring(0, num);
                Console.WriteLine(newSentence);
                Console.WriteLine($"The lenght of the new string is {newSentence.Length} characters");
            }
            else
            {
                Console.WriteLine("Enter a number from 1 to 31");
            }
        }
        public static string Substring()
        {
          string sentence = "Hello from SEDC Codecademy v7.0";
          return sentence;
        }
    }
}
