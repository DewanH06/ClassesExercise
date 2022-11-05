using ClassesExercise;
using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();

            //TODO

            //Create a seperate class file called car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property



            //Now that the car class is created we can instanciate 3 new cars
            //set the properties for each of the cars
            //Call each methods for each car

            //Dot Notation
            Car car1 = new Car();

            car1.Year = 2001;
            car1.Make = "Benz";
            car1.model = "CL55 AMG";
            car1.engineNoise = "VROOOOOOM";
            car1.HonkNoise = "HONKKK";
            car1.IsDriveable = true;

            carLot.ParkingLot.Add(car1);
        

            //Object Initializer syntax
            var car2 = new Car()
            {
                Year = 2016,
                Make = "Audi", 
                model = "A6",
                engineNoise = "Vroom Vroom", 
                HonkNoise = "beep", 
                IsDriveable = false 
            };

            carLot.ParkingLot.Add(car2);

            //Custom Constructor
            var car3 = new Car(2001, "Jeep", "wrangler", "vroom", "loud BEEP!", true);

            carLot.ParkingLot.Add(car3);

            car1.MakeEngineNoise(car1.engineNoise);
            car1.MakeHornNoise(car1.HonkNoise);

            car2.MakeEngineNoise("grt, grt, grt...");
            car2.MakeHornNoise(car2.HonkNoise);

            car3.MakeEngineNoise(car3.engineNoise);
            car3.MakeHornNoise(car3.HonkNoise);


            //****************BONUS****************

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //****************BONUS******************//

            //Create a CarLot class
            //It should have at least one property: a list of cars
            //Instanciate the a carlot at the beginning of the program and as you craete a car add the car to the list.
            //At the end iterate through the list printing each of car's year, make, and model to the console

            foreach(var vehicle in carLot.ParkingLot)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.model}");
                vehicle.MakeEngineNoise(vehicle.engineNoise);
                vehicle.MakeHornNoise(vehicle.HonkNoise);
                Console.WriteLine();
            }
        }

    }
}