using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Quizz_App
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Teacher()
        {

        }
        public Teacher(string firstname, string lastname, string user, string pass)
        {
            FirstName = firstname;
            LastName = lastname;
            FullName = FirstName + " " + LastName;
            UserName = user;
            Password = pass;
        }
        public static void SeeListOfStudents(List<Student> allStudents)
        {
            foreach (var item in allStudents)
            {
                if (item.IsFinished == true && item.Grade != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(item.FullName);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(item.FullName);
                    Console.ResetColor();
                }
            }
            Console.WriteLine("Press Enter to log out");
            ConsoleKeyInfo userKey = Console.ReadKey();
            if (userKey.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Loging out...");
                Thread.Sleep(2000);
            }

        }
        public static Teacher LoginAtemptTeacher(List<Teacher> allUsers)
        {
            var userDictonary = UserHelper.LoginMessage();
            var currentUser = new Teacher();

            if (allUsers.Any(x => userDictonary.Keys.FirstOrDefault().Equals(x.UserName)
           && userDictonary.Values.FirstOrDefault().Equals(x.Password)))
            {

                currentUser = allUsers.FirstOrDefault(x => x.UserName == userDictonary.Keys.FirstOrDefault());
                return currentUser;
            }
            else
            {
                Console.WriteLine("Wrong Username or Password\n2 attempts left");
                userDictonary = UserHelper.LoginMessage();
                currentUser = new Teacher();

                if (allUsers.Any(x => userDictonary.Keys.FirstOrDefault().Equals(x.UserName)
               && userDictonary.Values.FirstOrDefault().Equals(x.Password)))
                {

                    currentUser = allUsers.FirstOrDefault(x => x.UserName == userDictonary.Keys.FirstOrDefault());
                    return currentUser;
                }
                else
                {
                    Console.WriteLine("Wrong Username or Password\n1 attempts left");
                    userDictonary = UserHelper.LoginMessage();
                    currentUser = new Teacher();

                    if (allUsers.Any(x => userDictonary.Keys.FirstOrDefault().Equals(x.UserName)
                   && userDictonary.Values.FirstOrDefault().Equals(x.Password)))
                    {

                        currentUser = allUsers.FirstOrDefault(x => x.UserName == userDictonary.Keys.FirstOrDefault());
                        return currentUser;
                    }
                    else
                    {
                        throw new Exception("Wrong Username or Password");
                    }
                }
            }
        }
    }
}
