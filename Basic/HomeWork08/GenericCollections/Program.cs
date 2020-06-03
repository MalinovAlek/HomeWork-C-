using System;
using System.Collections.Generic;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //List
            List<string> names = new List<string>() { "Aleksandar", "Petar", "Maja", "Angela", "Elena" };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            //Queue
            Queue<int> queueNumbers = new Queue<int>();
            queueNumbers.Enqueue(1);
            queueNumbers.Enqueue(2);
            queueNumbers.Enqueue(3);
            queueNumbers.Enqueue(4);
            queueNumbers.Enqueue(5);

            int frontNumQ = queueNumbers.Peek();
            int frontNumQ2 = queueNumbers.Dequeue();
            Console.WriteLine(frontNumQ);
            Console.WriteLine(frontNumQ2);

            //Stack
            Stack<int> stackNumbers = new Stack<int>();
            stackNumbers.Push(6);
            stackNumbers.Push(7);
            stackNumbers.Push(8);
            stackNumbers.Push(9);
            stackNumbers.Push(10);

            int frontNumS = stackNumbers.Peek();
            int frontNumS2 = stackNumbers.Pop();
            Console.WriteLine(frontNumS);
            Console.WriteLine(frontNumS2);

            //Dictionary
            Dictionary<string, string> phoneBook = new Dictionary<string, string >();


            phoneBook.Add(names[0], "071987654");
            phoneBook.Add(names[1], "070123456");
            phoneBook.Add(names[2], "075875120");
            phoneBook.Add(names[3], "075875120");
            phoneBook.Add(names[4], "075875120");

            foreach (KeyValuePair<string, string> item in phoneBook)
            {
                Console.WriteLine($"Name: {item.Key}, Phone Number: {item.Value}");
            }
        }
    }
}
