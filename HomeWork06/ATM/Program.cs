using System;
using Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Costumer aleksandar = new Costumer("Aleksandar", 1234123412341234);
            Costumer pero = new Costumer("Pero", 9876987698769876);
            Costumer maja = new Costumer("Maja", 4444333322221111);
            Costumer ljupco = new Costumer("Ljupco", 8888888888888888);

            aleksandar.AddPin(1234);
            pero.AddPin(9876);
            maja.AddPin(1111);
            ljupco.AddPin(5555);

            aleksandar.AddBalance();
            pero.AddBalance();
            maja.AddBalance();
            ljupco.AddBalance();

            List<Costumer> costumerList = new List<Costumer> { aleksandar, pero, maja, ljupco };

            
            Console.WriteLine("If you want to create new user enter 'N' if not press any other key");
            string newUser = Console.ReadLine();

            if (newUser.ToLower() == "n")
            {
                NewUser(costumerList);
                Costumer[] costumerArr = costumerList.ToArray();
                Login(costumerArr);
            }
            else
            {
                Costumer[] costumerArr = costumerList.ToArray();
                Login(costumerArr);
            }

        }
        public static void Login(Costumer[] costumerArr)
        {
            Console.WriteLine("Enter Your Card Number with '-' after every 4 digits");
            //Bonus2
            string cardNumberCR = Console.ReadLine().Replace("-", string.Empty);

            if (long.TryParse(cardNumberCR, out long cardNumber))
            {
                foreach (var costumer in costumerArr)
                {
                    
                    if (cardNumber == costumer.CardNum)
                    {
                        Console.WriteLine("Enter Your Pin");
                        string pinCR = Console.ReadLine();

                        if (int.TryParse(pinCR, out int pin))
                        {
                            TransactionOptions(costumer, costumerArr, pin);
                        }
                        else { Console.WriteLine("Wrong Pin!");  }
                        }
                    }
            }
            else { Console.WriteLine("Wrong Input"); }

        }
        public static void AnohterTransaction(Costumer costumer, Costumer[] costumerArr,int pin)
        {
            Console.WriteLine("Do you want to do another transaction?\n 1.Yes \n 2.No");
            string anotherTransaction = Console.ReadLine();
            if (anotherTransaction == "1")
            {
                TransactionOptions(costumer, costumerArr,pin);
            }
            else if (anotherTransaction == "2")
            {
                Console.WriteLine("Goodbye");
                
                Login(costumerArr);
            }
            else { Console.WriteLine("Invalid Input"); }
        }
       public static void TransactionOptions(Costumer costumer, Costumer[] costumerArr,int pin)
       {
    
            costumer.PinCheck(pin);
            string userOption = Console.ReadLine();

            switch (userOption)
            {
                case "1":
                    Console.WriteLine(costumer.BalanceCheck());
                    AnohterTransaction(costumer,costumerArr,pin);
                    break;
                case "2":
                    Console.WriteLine($"{costumer.BalanceCheck()} \nEnter the amount you want to withdraw");
                    string withdraw = Console.ReadLine();
                    costumer.Withdrawal(withdraw);
                    AnohterTransaction(costumer,costumerArr,pin);
                    break;
                case "3":
                    Console.WriteLine($"{costumer.BalanceCheck()} \nEnter the amaount that you want to deposit");
                    string depositCR = Console.ReadLine();
                    if (int.TryParse(depositCR, out int deposit))
                    {
                    costumer.Deposit(deposit);
                    AnohterTransaction(costumer, costumerArr, pin);
                    break;
                    }
                    else 
                    { 
                    Console.WriteLine("Wrong Input!");
                    break;
                    }
            
                default:
                    Console.WriteLine("Wrong Input!");
                    break;
            }

       }
        public static void NewUser(List<Costumer> costumerList)
        {
            Console.WriteLine("Enter Your name");
            string name = Console.ReadLine();
            Random rnd = new Random();
            int cardNumber1 = rnd.Next(10000000,99999999);
            int cardNumber2 = rnd.Next(10000000,99999999);
            string cardNumberSTR = String.Concat(cardNumber1, cardNumber2);
            int pin = rnd.Next(1000,9999);

            if (long.TryParse(cardNumberSTR,out long cardNumber))
            {
                for (int i = 0; i < costumerList.Count; i++)
                {
                    if (cardNumber == costumerList[i].CardNum)
                    {
                        Console.WriteLine("Try again");
                        return;
                    }
                }

                Costumer user1 = new Costumer(name, cardNumber);
                user1.AddPin(pin);
                user1.AddBalance();
                Console.WriteLine($"Your card number is:{cardNumber} your pin is {pin}");
                costumerList.Add(user1);
               
            }
           
        }
    }
}
