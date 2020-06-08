using System;
using System.Collections.Generic;
using System.Threading;

namespace Quizz_App
{
    public class Question
    {
        public string Title { get; set; }
        public List<string> Choices { get; set; } = new List<string>();
        public int CorrectAnswer { get; set; }
        public Question()
        {

        }
        public Question(string title, List<string> choices, int correct)
        {
            Title = title;
            Choices = choices;
            CorrectAnswer = correct;
        }
        public static List<Question> GetAllQuestions()
        {
            List<string> q1 = new List<string>();
            q1.Add("1.Dodoma");
            q1.Add("2.Hobart");
            q1.Add("3.Launceston");
            q1.Add("4.Wellington");

            List<string> q2 = new List<string>();
            q2.Add("1.Kinshasa Democratic Republic of the Congo Temple");
            q2.Add("2.Palais de la Nation");
            q2.Add("3.Kongo Trade Centre");
            q2.Add("4.Nabemba Tower");

            List<string> q3 = new List<string>();
            q3.Add("1.Styx");
            q3.Add("2.Benxi Lake");
            q3.Add("3.Nix");
            q3.Add("4.Lugia");

            List<string> q4 = new List<string>();
            q4.Add("1.Onega Lake");
            q4.Add("2.Styx");
            q4.Add("3.Kivu Lake");
            q4.Add("4.Wakatipu Lake");

            List<string> q5 = new List<string>();
            q5.Add("1.Chad");
            q5.Add("2.Peru");
            q5.Add("3.Australia");
            q5.Add("4.Niger");

            Question question1 = new Question("What is the capital of Tasmania?",q1,2);
            Question question2 = new Question("What is the tallest building in the Republic of the Congo?", q2,4);
            Question question3 = new Question("Which of these is not one of Pluto's moons?", q3,4);
            Question question4 = new Question("What is the smallest lake in the world?", q4,2);
            Question question5 = new Question("What country has the largest population of alpacas?", q5,2);

            List<Question> QuestionsList = new List<Question> { question1 , question2 , question3 , question4, question5 };
            return QuestionsList;
        }
        public static void TakeQuiz(Student student)
        {
            List<Question> questions = GetAllQuestions();
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine(questions[i].Title);
                questions[i].Choices.ForEach(Console.WriteLine);
                string answerStr = Console.ReadLine();
                if (int.TryParse(answerStr, out int answer))
                {
                    if (answer > 0 && answer <= questions[i].Choices.Count)
                    {
                        if (answer == questions[i].CorrectAnswer)
                        {
                            student.Grade++;
                        }
                        student.IsFinished = true;
                    }
                    else { throw new Exception($"You must enter a number from 1 to {questions[i].Choices.Count}"); }
                }
                else { throw new Exception($"You must enter a number"); }
            }
            Console.Clear();
            if (student.Grade != 0 && student.Grade !=1)
            {
                Console.WriteLine($"{student.FullName} your grade is {student.Grade}\nLoging out...");
            }
            else { Console.WriteLine($"{student.FullName} your failed to pass the test\nLoging out..."); }

            Thread.Sleep(2000);
        }

    }
}
