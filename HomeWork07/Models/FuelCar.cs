using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class FuelCar : Car
    {
        public int FuelCapacity { get; set; }
        public int CurrentFuel { get; set; }
        public FuelCar(string brand, string model, int doors, int topSpeed, Consumption consumption, 
      int fuelCapacity)
           : base(brand, model, doors, topSpeed, consumption)
        {
            FuelCapacity = fuelCapacity;
            EngineType = EngineType.Petrol;
        }
        public void Drive(int distance)
        {
            CurrentFuel = distance * (int)Consumption / 10;
            if (CurrentFuel > FuelCapacity)
            {
                Console.WriteLine("You can't drive drive more than the capacity of the fuel tank");
            }
        }
        public void Refuel(int fuel)
        {
            CurrentFuel += fuel;
            if (CurrentFuel > FuelCapacity)
            {
                Console.WriteLine($"Can't refuel more than {FuelCapacity} litres");
                CurrentFuel = FuelCapacity;
            }
        }
    }
}
