using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[] { "Alek", "Ljupco", "Maja", "Mila", "Mino"};
            string[] studentsG2 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
          
            Console.WriteLine("Select a group (1 or 2)");
            var group = Console.ReadLine();
            if (group == "1")
            {
                Console.WriteLine("The students in G1 are: ");
                for (int i = 0; i < studentsG1.Length; i++)
                {
                    Console.WriteLine(studentsG1[i]);
                }
                
            } else if (group == "2")
            {
                Console.WriteLine("The students in G2 are: ");
                foreach (var student in studentsG2)
                {
                    Console.WriteLine(student);
                }
            }
            else { Console.WriteLine("You must enter 1 or 2"); }

        }
    }
}
