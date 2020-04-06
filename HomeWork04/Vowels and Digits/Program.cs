using System;

namespace Vowels_and_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();

            Console.WriteLine($"The text {text} contains {Digits(text)} digit/s and {Vowels(text)} vowel/s.");
            
        }
        public static int Digits(string text)
        {
            int counter = 0;
            char[] textArr = text.ToCharArray();

            foreach (var item in textArr)
            {
                if (Char.IsDigit(item))
                {
                    counter++;
                }
            }

            return counter;

        }
        public static int Vowels(string text)
        {
            int counter = 0;
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            char[] textArr = text.ToCharArray();

            for (int i = 0; i < vowels.Length; i++)
            {
                for (int j = 0; j < textArr.Length; j++)
                {
                    if (vowels[i] == textArr[j])
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }
    }
}
