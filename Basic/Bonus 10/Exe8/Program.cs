using System;

namespace Exe8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome dear costumer please select a drink: ");
            Console.WriteLine("1. Espresso...........2$");
            Console.WriteLine("2. Macchiato........3,5$");
            Console.WriteLine("3. Latte..............4$");
            Console.WriteLine("4. Cappuccino.........6$");
            Console.WriteLine("5. Tea..............1.5$");
            string drink = Console.ReadLine();
            double amount = 0;
           
            if (drink == "1" || drink == "2" || drink == "3" || drink == "4" || drink == "5")
            {
                Console.WriteLine("Please enter sweetnes level from 1-5");
                string sugar = Console.ReadLine();
                if (sugar == "1" || sugar == "2" || sugar == "3" || sugar == "4" || sugar == "5")
                {

                    switch (drink)
                    {
                        case "1":
                            Console.WriteLine("Please insert 2$");
                            amount = 2;
                            drink = "Espresso";
                            break;
                        case "2":
                            Console.WriteLine("Please insert 3.5$");
                            amount = 3.5;
                            drink = "Macchiato";
                            break;
                        case "3":
                            Console.WriteLine("Please insert 4$");
                            amount = 4;
                            drink = "Latte";
                            break;
                        case "4":
                            Console.WriteLine("Please insert 6$");
                            amount = 6;
                            drink = "Cappuccino";
                            break;
                        case "5":
                            Console.WriteLine("Please insert 1.5$");
                            amount = 1.5;
                            drink = "Tea";
                            break;
                        default:
                            Console.WriteLine("Error, incorrect value");
                            break;
                    }

                    Console.WriteLine("Input money");
                    string moneyCR = Console.ReadLine();
                    if (double.TryParse(moneyCR, out double money))
                    {
                        if (money >= amount)
                        {
                            Console.WriteLine("Have a drink");
                        }
                        else { 
                            Console.WriteLine("The " + drink + " costs " + amount + " ,you are missing " + (amount - money) + " to buy it");
                            string moreMoneyCR = Console.ReadLine();
                            if (double.TryParse(moreMoneyCR, out double moreMoney))
                            {
                                if (moreMoney >= (amount - money))
                                {
                                    Console.WriteLine("Have a drink");
                                } else
                                {
                                    Console.WriteLine("Are you dumb?");
                                }
                            }
                           
                        }
                    }
                }
                else { Console.WriteLine("Sweetnes level must be from 1-5"); }
            }
            else { Console.WriteLine("You must select from 1-5"); }


           
          
        }
    }
}
