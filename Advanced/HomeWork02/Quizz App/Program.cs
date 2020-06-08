using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;



namespace Quizz_App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Student> allStudents = UserHelper.GetAllStudents();
                List<Teacher> allTeachers = UserHelper.GetAllTeachers();
                while (true)
                {
                    Console.Clear();

                    string user = UserHelper.TeacherorStudent();
                    if (user == "1")
                    {
                        Student currentStudent = Student.LoginAtemptStudent(allStudents);
                        if (currentStudent.IsFinished == false)
                        {
                            Console.Clear();
                            Console.WriteLine($"Welcome {currentStudent.FullName}");
                            Question.TakeQuiz(currentStudent);

                        }
                        else 
                        { 
                            Console.WriteLine($"{currentStudent.FullName} you have already taken the test.\nLoging out...");
                            Thread.Sleep(2000);
                        }

                    }
                    else
                    {
                        Teacher currentTeacher = Teacher.LoginAtemptTeacher(allTeachers);
                        Console.WriteLine($"Welcome {currentTeacher.FullName}\nList of students:");
                        Teacher.SeeListOfStudents(allStudents);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nRestart the app");
            }

        }       
    }
}
