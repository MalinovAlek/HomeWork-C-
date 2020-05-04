using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ElectricCar : Car
    {
        public double BatteryCapacity { get; set; }
        public double BatteryUsage { get; set; }

        public ElectricCar(string brand, string model, int doors, int topSpeed, Consumption consumption, 
        int batteryCapacity)
            :base(brand,model,doors,topSpeed,consumption)
        {
            EngineType = EngineType.Electric;
            BatteryCapacity = batteryCapacity;
        }
        public void Drive(int distance)
        {
            int result = distance * (int)Consumption / 10;
            //Percentage of used battery
            BatteryUsage = (result * 100)/ BatteryCapacity;
         
            if (BatteryUsage > 100)
            {
                Console.WriteLine("You can't drive drive more than the capacity of the battery");
            }
        }
        public void Recharge(double minutes)
        {
            double reamainingBattery = 100 - BatteryUsage;
            reamainingBattery +=  minutes * 0.1;
            BatteryUsage = 100 - reamainingBattery;

            if (reamainingBattery > 100)
            {
                Console.WriteLine($"You can't charge more than {minutes} minutes");
                reamainingBattery = 100;
                BatteryUsage = 0;
            }
        }
    }
}
