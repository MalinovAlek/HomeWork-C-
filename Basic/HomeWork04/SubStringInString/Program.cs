using System;
using System.Text.RegularExpressions;

namespace SubStringInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write text!");
            string text = Console.ReadLine();
            Console.WriteLine("Enter substring");
            string substring = Console.ReadLine();
            Console.WriteLine($"The substring {substring} appears {SubstringInString(text, substring)} times in the text {text}");
        }

        public static int SubstringInString(string text, string substring)
        {
    
            int result = Regex.Matches(text, substring).Count;
            return result;
        }

    
        //public static int SubstringInString(string text, string substring)
        //{
        //    int result = 0;
        //    if (text.Contains(substring))
        //    {
        //        for (int i = 0; i < text.Length; i++)
        //        {
        //            if (text.Substring(i).Length >= substring.Length)
        //            {
        //                bool equals = text.Substring(i, substring.Length).Equals(substring);
        //                if (equals)
        //                {
        //                    result++;
        //                    i += substring.Length - 1;
        //                }
        //            }
        //        }
        //    }


        //    return result;
        //}
    }
}
