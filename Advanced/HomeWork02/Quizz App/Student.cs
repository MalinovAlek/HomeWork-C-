using System;
using System.Collections.Generic;
using System.Linq;

namespace Quizz_App
{
    public class Student : Teacher
    {
        public int Grade { get; set; } = 0;
        public bool IsFinished { get; set; } = false;
        public Student()
        {

        }
        public Student(string firstname, string lastname, string user, string pass)
         : base(firstname, lastname, user, pass)
        {

        }
        public static Student LoginAtemptStudent(List<Student> allUsers)
        {
            var userDictonary = UserHelper.LoginMessage();
            var currentUser = new Student();

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
                currentUser = new Student();

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
                    currentUser = new Student();

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
