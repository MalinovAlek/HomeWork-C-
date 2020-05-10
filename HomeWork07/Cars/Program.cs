using System;
using Models;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {

            ElectricCar tesla = new ElectricCar("Tesla", "Model S", 4, 262, Consumption.Economic,  2000,200);
            ElectricCar bmw = new ElectricCar("BMW", "I3", 4, 242, Consumption.Economic, 1000,500);
            ElectricCar chevrolet = new ElectricCar("Chevrolet", "I3", 4, 242, Consumption.Economic, 1458,1458);
            tesla.Drive(120);
            bmw.Drive(250000);
            chevrolet.Drive(250);


            tesla.Recharge(20);
            bmw.Recharge(100);
            chevrolet.Recharge(5);

            FuelCar opel = new FuelCar("Opel", "Astra", 4, 220, Consumption.Medium,1800,1000);
            FuelCar renault = new FuelCar("Renault", "Clio", 2, 180, Consumption.High, 1500,1000);
            opel.EngineType = EngineType.Disel;
            opel.Drive(200000);
            opel.Refuel(1800);

            renault.Drive(2500);
            renault.Refuel(500);

        }
    }
}
