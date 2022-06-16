using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car-DONE 
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable-DONE

            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()-DONE
            //The methods should take one string parameter: the respective noise property-DONE


            //Now that the Car class is created we can instanciate 3 new cars-DONE
            var tesla = new Car();
            tesla.Year = 2021;
            tesla.Make = "tesla";
            tesla.Model = "model s";
            tesla.EngineNoise = "prrr";
            tesla.HonkNoise = "wink wink";
            tesla.IsDriveable = true;

            var hyundai = new Car()
            {
                Year = 2014,
                Make = "hyundai",
                Model = "sonata",
                EngineNoise = "weeee",
                HonkNoise = "weh weh",
                IsDriveable = true
            };

            var ford = new Car(2020, "Ford", "Mustang", "Pooof", "Bunk Funk", false);


            //Set the properties for each of the cars-DONE

            //Call each of the methods for each car-DONE
            tesla.MakeEngineNoise(tesla.EngineNoise);
            tesla.MakeHonkNoise(tesla.HonkNoise);

            hyundai.MakeEngineNoise(hyundai.EngineNoise);
            hyundai.MakeHonkNoise(hyundai.HonkNoise);

            ford.MakeEngineNoise(ford.EngineNoise);
            ford.MakeEngineNoise(ford.HonkNoise);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car-DONE


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}.");

            for(int i = 0; i > CarLot.numberOfCars; i++)
            {
                Console.WriteLine($"Year: {ford.Year}, {tesla.Year}");
            }
        }
    }
}
