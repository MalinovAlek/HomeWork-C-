using System;
using System.Linq;
namespace LowerToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            Console.WriteLine(CaseTransform(text));
        }
        public static string CaseTransform(string text)
        {

            string result = "";
            
           
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsUpper(text[i]))
                {
                    result += char.ToLower(text[i]);

                } else {result += char.ToUpper(text[i]);};
            }
            
            return $"The text you have entered {text}\nThe result: {result}";
        }
    }
}
