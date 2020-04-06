using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Dog
{
    class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public string Eat()
        {
            return $"{Name} is now eating";
        }
        public string Play()
        {
            return $"{Name} is now playing";
        }
        public string ChasingTail()
        {
            return $"{Name} is now chasing its tail";
        }

        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;
        }
    }
}
