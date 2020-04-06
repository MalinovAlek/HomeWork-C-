using System;

namespace Exe7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            string ageCR = Console.ReadLine();
            if (int.TryParse(ageCR, out int age))
            {
                if (age >= 18)
                {
                    Console.WriteLine("What kind of drink you want to drink?");
                    string drink = Console.ReadLine();
                    Console.WriteLine("Dear " + name + " " + lastName + " here is a bottle of " + drink );
                } else
                { Console.WriteLine("Dear " + name + " " + lastName + " I am sorry but you are not allowed to buy alchocol "); }
            } else {Console.WriteLine("Please enter a valid input!");}
        }
    }
}
