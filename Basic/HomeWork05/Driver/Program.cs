using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Driver
{
    class Program
    {

        static void Main(string[] args)
        {
            Driver driver1 = new Driver("Pero", 9);
            Driver driver2 = new Driver("Goki", 8);
            Driver driver3 = new Driver("Filip", 7);
            Driver driver4 = new Driver("Martin", 9);

            Car car1 = new Car("Ford", 180, driver1);
            Car car2 = new Car("Polo", 160, driver2);
            Car car3 = new Car("Golf", 200, driver3);
            Car car4 = new Car("Alfa-Romeo", 190, driver4);

            List<Driver> drivers = new List<Driver> { driver1,driver2,driver3,driver4 };
            List<Car> cars = new List<Car> { car1, car2, car3, car4 };

            //Player1

            Console.WriteLine("Chose a driver:");
            for (int i = 0; i < drivers.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{ drivers[i].Name}");
            }

            //Driver 1
            string inputDriver1 = Console.ReadLine();

            Driver selectDriver1 = driver1;

           switch (inputDriver1)
            {
                case "1":
                    selectDriver1 = driver1;
                    drivers.RemoveAt(0);
                    break;
                case "2":
                    selectDriver1 = driver2;
                    drivers.RemoveAt(1);
                    break;
                case "3":
                    selectDriver1 = driver3;
                    drivers.RemoveAt(2);
                    break;
                case "4":
                    selectDriver1 = driver4;
                    drivers.RemoveAt(3);
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    return;
            }

            //Car1
            Console.WriteLine("Chose a car:");
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{ cars[i].Model}");
            }
            string inputCar1 = Console.ReadLine();

            Car selectCar1 = new Car("Ford", 180, driver1);

            switch (inputCar1)
            {
                case "1":
                    selectCar1 = new Car(cars[0].Model, cars[0].Speed, selectDriver1);
                    cars.RemoveAt(0);
                    break;
                case "2":
                    selectCar1 = new Car(cars[1].Model, cars[1].Speed, selectDriver1);
                    cars.RemoveAt(1);
                    break;
                case "3":
                    selectCar1 = new Car(cars[2].Model, cars[2].Speed, selectDriver1);
                    cars.RemoveAt(2);
                    break;
                case "4":
                    selectCar1 = new Car(cars[3].Model, cars[3].Speed, selectDriver1);
                    cars.RemoveAt(3);
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    return;
            }


            Console.WriteLine($"You selected the driver {selectCar1.Driver.Name} driving a {selectCar1.Model}");

            //Player2

            //Driver2

            Console.WriteLine("Chose a driver:");
            for (int i = 0; i < drivers.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{ drivers[i].Name}");
            }

            string inputDriver2 = Console.ReadLine();

            Driver selectDriver2 = driver1;

            switch (inputDriver2)
            {
                case "1":
                    selectDriver2 = drivers[0];
                    break;
                case "2":
                    selectDriver2 = drivers[1];
                    break;
                case "3":
                    selectDriver2 = drivers[2];
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    return;
            }

            //Car2;

            Console.WriteLine("Chose a car:");
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{ cars[i].Model}");
            }
            string inputCar2 = Console.ReadLine();

            Car selectCar2 = new Car("Ford", 180, driver2);

            switch (inputCar2)
            {
                case "1":
                    selectCar2 = new Car(cars[0].Model, cars[0].Speed, selectDriver2);
                    break;
                case "2":
                    selectCar2 = new Car(cars[1].Model, cars[1].Speed, selectDriver2);
                    break;
                case "3":
                    selectCar2 = new Car(cars[2].Model, cars[2].Speed, selectDriver2);
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    return;
            }

            Console.WriteLine($"You selected the driver {selectCar2.Driver.Name} driving a {selectCar2.Model}");

            Console.WriteLine(RaceCars(selectCar1, selectCar2));

            Console.WriteLine("If you want to race again press 'R' ");
            string raceAgain = Console.ReadLine();

            //Restart
            if (raceAgain == "r" || raceAgain == "R")
            {
                Main(args);
            }

        }
        public static string RaceCars(Car car1, Car car2)
        {
            if (car1.CalculateSpeed(car1.Driver) > car2.CalculateSpeed(car2.Driver))
            {
                return $"The drivier {car1.Driver.Name} driving a {car1.Model} with speed of {car1.Speed}km/h wins";
            } else if (car1.CalculateSpeed(car1.Driver) < car2.CalculateSpeed(car2.Driver))
            {
                return $"The drivier {car2.Driver.Name} driving a {car2.Model} with speed of {car2.Speed}km/h wins";
            } else
            {
                return "It's a tie race!";
            }
         }

    }
}
