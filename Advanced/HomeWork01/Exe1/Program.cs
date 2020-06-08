using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NameInText
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Create a console application that detect provided names in a provided text 🔹
            // The application should ask for names to be entered until the user enteres x
            // After that the application should ask for a text
            // When that is done the application should show how many times that name was included in the text ignoring upper / lower case
            Console.WriteLine("Enter names, and pres X when you want to stop");
            List<string> allNames = new List<string>() { };
            EnterNames(allNames);
        }
        static void EnterNames(List<string> allNames)
        {
           
            var inputNames = Console.ReadLine();
          
            if (inputNames.ToUpper() != "X")
            {
                allNames.Add(inputNames);
                EnterNames(allNames);
            }
            else 
            { 
                Console.WriteLine("Enter text");
                string inputText = Console.ReadLine();

                for (int i = 0; i < allNames.Count; i++)
                {
                    int result = Regex.Matches(inputText.ToLower(), allNames[i].ToLower()).Count;
                    Console.WriteLine($"{allNames[i]} is mentioned {result} times");
                }
              
            }
        }

        }
}
