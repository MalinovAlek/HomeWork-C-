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
      int fuelCapacity, int currentFuel)
           : base(brand, model, doors, topSpeed, consumption)
        {
            FuelCapacity = fuelCapacity;
            CurrentFuel = currentFuel;
            EngineType = EngineType.Petrol;

        }
        public void Drive(int distance)
        {
            int usedFuel = distance * (int)Consumption / 10;
            if (usedFuel > CurrentFuel)
            {
                Console.WriteLine("You can't drive drive more than the capacity of the fuel tank");
            }
            else { CurrentFuel -= usedFuel;} 
        }
        public void Refuel(int fuel)
        {
            if (CurrentFuel + fuel > FuelCapacity)
            {
                Console.WriteLine($"Can't refuel more than {FuelCapacity} litres");
                CurrentFuel = FuelCapacity;
            } else { CurrentFuel += fuel; }
        }
    }
}
