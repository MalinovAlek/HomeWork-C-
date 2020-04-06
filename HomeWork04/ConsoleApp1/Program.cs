using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if a word is palindrome");
            string word = Console.ReadLine();
            Console.WriteLine(Palindrome(word));
            
        }
        public static string Palindrome(string word)
        {
            bool trueOrFalse = false;
            string firstPart = word.Substring(0, (word.Length / 2));
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            string tempString = new string(arr);
            string secondPart = tempString.Substring(0, (word.Length / 2));
            if (firstPart == secondPart)
            {
                trueOrFalse = true;
            } 
            else {trueOrFalse = false;};
            if (trueOrFalse)
            {
                return $"{word} is a palindrom";
            } else 
            {
                return  $"{word} is not a palindrom";
             };

            
        }
    }
}
