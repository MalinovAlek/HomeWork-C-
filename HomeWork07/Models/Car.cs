using System;

namespace Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }
        public Consumption Consumption { get; set; }
        public EngineType EngineType { get; set; }
        Random rnd = new Random();

        public Car(string brand, string model, int doors, int topSpeed, Consumption consumption)
        {
            Id = rnd.Next(1, 999);
            Brand = brand;
            Model = model;
            Doors = doors;
            TopSpeed = topSpeed;
            Consumption = consumption;
        }
        public Car() { }
        public string PrintInfo()
        {
            return $"{Brand} {Model}";
        }
    }
}
