using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Costumer
    {
        public string Name { get; set; }
        public long CardNum { get; set; }
        private int Pin { get; set; }
        private int Balance { get; set; }

        public Costumer(string name, long cardNum)
        {
            Name = name;
            CardNum = cardNum;
            Pin = 0;
            Balance = 0;
        }
        public void AddPin(int pin)
        {
            Pin = pin;
        }
        public void AddBalance()
        {
            Random rnd = new Random();
            Balance = rnd.Next(50000);
        }
        public void PinCheck(int pin)
        {
           
            if (pin == Pin)
            {
                
                Console.WriteLine($"Welcome {Name}\nWhat would you like to do?\n1.Check Balance\n2.Cash Withdrawal\n3.Cash Deposit");
            }
            else { Console.WriteLine("Wrong PIN!"); }
        }
        public string BalanceCheck()
        {
            return $"Your current balance of money is {Balance} denari"; 
        }
        public void Withdrawal(string withdrawCR)
        {
            if (int.TryParse(withdrawCR, out int withdraw))
            {
                if (withdraw > Balance)
                {
                    Console.WriteLine("You don't have enough money on your account");
                }
                else
                {
                    Console.WriteLine($"You withdrew {withdraw} denari. You have {Balance - withdraw} denari left on your account");
                }
            }
           
        }
        public void Deposit(int deposit)
        {
            Console.WriteLine($"Your current balance is now {deposit + Balance} denari");
        }
     
        

    }
}
