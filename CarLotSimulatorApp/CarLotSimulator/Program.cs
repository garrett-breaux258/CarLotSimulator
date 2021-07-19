using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            var carLot = new CarLot();

        //Now that the Car class is created we can instanciate 3 new cars
        //Set the properties for each of the cars
        //Call each of the methods for each car
        var car1 = new Car();
            car1.Year = 2001;
            car1.Make = "Nissan";
            car1.Model = "Altima";
            car1.EngineNoise = "quiet";
            car1.HonkNoise = "whiney";
            car1.isDriveable = true;
            carLot.Cars.Add(car1);
     

            var car2 = new Car() { Year = 2002, Make = "Chevy", Model = "Camaro", EngineNoise = "sexy", HonkNoise = "quiet", isDriveable = false } ;
            carLot.Cars.Add(car2);

            var car3 = new Car()
            {
                Year = 2003,
                Make = "Toyota",
                Model = "tundra",
                EngineNoise = "strong",
                HonkNoise = "loud",
                isDriveable = true
            };
            carLot.Cars.Add(car3);

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");
            foreach (var item in carLot.Cars)
            {
                item.MakeEngineNoise();
                item.MakeHonkNoise();
            }
            Console.WriteLine("");
            Console.WriteLine("Year Make Model");
            Console.WriteLine("---------------");
            foreach (var item in carLot.Cars)
            {
                Console.WriteLine($"{item.Year} {item.Make} {item.Model}");
            }

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
