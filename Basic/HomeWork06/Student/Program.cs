using System;
using Models;

namespace AcademyStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student aleksandar = new Student("Aleksandar", "SEDC", 5);
            Student goran = new Student("Goran", "Code-Academy", 2);
            Student darko = new Student("Darko", "Brainster", 1);
            Student david = new Student("David", "SEDC", 2);
            Student rosica = new Student("Rosica", "Brainster", 1);

            Student[] studentsArr = { aleksandar, goran, darko, david, rosica };

            Console.WriteLine("Enter a name");
            string userInput = Console.ReadLine();
            string output = string.Empty;

            foreach (var student in studentsArr)
            {
                if (userInput.ToLower() == student.Name.ToLower())
                {
                    output = student.StudentInfo(); break;
                }
                else { output = "No student with that name"; }

            }
            Console.WriteLine(output);
        }
    }
}
