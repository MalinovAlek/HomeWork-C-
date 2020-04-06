using System;

namespace AlphabetCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write one character");
            string textCR = Console.ReadLine();
            if (char.TryParse(textCR, out char letter))
            {
                Console.WriteLine(AlphabetChecker(letter)); 
            }
            else { Console.WriteLine("You must write only one character"); }
           
        }

        public static string AlphabetChecker(char letter)
        {
            string result = "";
            if (Char.IsLetter(letter))
            {
                if (Char.IsUpper(letter))
                {
                    result = $"The character {letter} is an alphabet letter and is Upper Case";
                } else { result = $"The character {letter} is an alphabet letter and is Lower Case"; }
                

            } else { result =  $"The character {letter} is NOT an alphabet letter"; };
            return result;
        }
        
    }
}
