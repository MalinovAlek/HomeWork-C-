using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors
{
    static class Scores
    {
        public static List<int> scoreList;
    }
    class Program
    {
       
        static void Main(string[] args)
        {

            Scores.scoreList = new List<int> { 0, 0, 0 };
            try
            {
              
                while (true)
                {
                   
                    Console.WriteLine("Chose one of the following options \n1. Play \n2. Stats \n3. Exit");
                    string userOption = Console.ReadLine();
                    if (userOption == "1")
                    {
                        Play();

                    }
                    else if (userOption == "2")
                    {
                        Stats();
                    }
                    else if (userOption == "3")
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                    else
                    {
                        throw new Exception($"You must a number from 1 to 3");
                    }
                }
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Stats()
        {
            int total = Scores.scoreList.Sum();
            if (total > 0)
            {
               
                Console.WriteLine($"Result is: USER - { Scores.scoreList[0]}, COMPUTER - { Scores.scoreList[1]}, DRAWS - { Scores.scoreList[2]}");
                Console.WriteLine($"USER WINS - {100 / total * Scores.scoreList[0]}% \nUSER LOSS - {100 / total * Scores.scoreList[1]}" +
                    $"% \nUSER DRAWS - {100 / total * Scores.scoreList[2]}%");
            }
            else 
            { 
                Console.WriteLine("Play at least one game so you can see the stats!");
            }
         
        }
        static void RockPaperScissors(string input1, string input2) 
        {
           
                if ((input1 == "Rock" && input2 == "Scissors") || (input1 == "Scissors" && input2 == "Paper")
                  || (input1 == "Paper" && input2 == "Rock"))
                {
                    Scores.scoreList[0]++;
                    Console.WriteLine("User win.");
                }
                else if ((input2 == "Rock" && input1 == "Scissors") || (input2 == "Scissors" && input1 == "Paper")
                  || (input2 == "Paper" && input1 == "Rock"))
                {
                    Scores.scoreList[1]++;
                    Console.WriteLine("Computer win");
                }
                else if ((input1 == "Rock" && input2 == "Rock") || (input1 == "Paper" && input2 == "Paper")
                    || (input1 == "Scissors" && input2 == "Scissors"))
                {
                    Scores.scoreList[2]++;
                    Console.WriteLine("It's a draw");
                }
                else { throw new Exception($"You must a number from 1 to 3"); }
          

        }
        static void Play()
        {
           Console.WriteLine("Chose:\n1. Rock \n2. Paper \n3. Scissors");
           string userChoise = Console.ReadLine();

            switch (userChoise)
            {
                case "1":
                    userChoise = "Rock";
                    break;
                case "2":
                    userChoise = "Paper";
                    break;
                case "3":
                    userChoise = "Scissors";
                    break;
                default:
                    throw new Exception($"You must a number from 1 to 3");
            }
                Random rnd = new Random();
                int comChoise = rnd.Next(1, 4);
                string comRPC = String.Empty;
                switch (comChoise)
                {
                    case 1:
                        comRPC = "Rock";
                        break;
                    case 2:
                        comRPC = "Paper";
                        break;
                    case 3:
                        comRPC = "Scissors";
                        break;
                    default:
                        Console.WriteLine("You must enter number from 1-3");
                        break;
                }
                Console.WriteLine($"You chose {userChoise}, computer chose {comRPC}");
                RockPaperScissors(userChoise, comRPC);
          


        }
       
        }
}
