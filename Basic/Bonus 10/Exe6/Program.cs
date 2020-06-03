using System;

namespace Exe6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence!");
            string text = Console.ReadLine();

            int wordCount = 0, index = 0;

            while (index < text.Length && char.IsWhiteSpace(text[index]))
                index++;

            while (index < text.Length)
            {
             
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;

                wordCount++;

                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }
            Console.WriteLine(wordCount);
        }
    }
}
