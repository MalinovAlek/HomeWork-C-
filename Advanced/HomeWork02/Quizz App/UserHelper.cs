using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Quizz_App
{
    public class UserHelper
    {
        public static List<Student> GetAllStudents()
        {

            Student student1 = new Student("Aleksandar", "Malinov", "Alek123", "qwerty1");
            Student student2 = new Student("Martin", "Andreev", "Mac", "mac123");
            Student student3 = new Student("Petar", "Davitkovski", "Petar678", "asdf3");
            Student student4 = new Student("Goran", "Cvetkovski", "Gokic1994", "98765q");
            Student student5 = new Student("Test", "Testovski", "a", "1");
            List<Student> allStudents = new List<Student>() { student1, student2, student3, student4, student5 };

            return allStudents;
        }
        public static List<Teacher> GetAllTeachers()
        {
            Teacher teacher1 = new Teacher("Andrej", "Chichakovski", "Andrej123", "qwerty");
            Teacher teacher2 = new Teacher("Risto", "Panchevski", "Risto123", "qwerty2");
            Teacher teacherTest = new Teacher("Teacher", "Testovski", "a", "1");
            List<Teacher> allTeachers = new List<Teacher>() { teacher1, teacher2, teacherTest };

            return allTeachers;
        }

        public static string TeacherorStudent()
        {
            Console.WriteLine("Are you:\n1.Student\n2.Teacher");
            string teacherOrStudent = Console.ReadLine();
            if (teacherOrStudent == "1" || teacherOrStudent == "2")
            {
                return teacherOrStudent;
            }
            else { throw new Exception("You must select 1 or 2"); }
        }
        public static Dictionary<string, string> LoginMessage()
        {

            Console.WriteLine("Enter Username");
            string userNameInput = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            Dictionary<string, string> userNamePassword = new Dictionary<string, string>();
            userNamePassword.Add(userNameInput, password);
            return userNamePassword;
        }



    }
}
