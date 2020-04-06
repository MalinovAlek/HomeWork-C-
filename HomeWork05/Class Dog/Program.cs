using System;


namespace Class_Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Dog Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Dog Race");
            string race = Console.ReadLine();

            Console.WriteLine("Enter Dog Color");
            string color = Console.ReadLine();

            Console.WriteLine("Chose a dog action:");
            Console.WriteLine("1. Eat");
            Console.WriteLine("2. Play");
            Console.WriteLine("3. Chasing Tail");
            string dogAction = Console.ReadLine();

            Dog dog = new Dog(name, race, color);

            switch (dogAction)
            {
                case "1":
                    Console.WriteLine(dog.Eat());
                    break;
                case "2":
                    Console.WriteLine(dog.Play());
                    break;
                case "3":
                    Console.WriteLine(dog.ChasingTail());
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
            
         
            
           
        }
    }
}
