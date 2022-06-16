using System;
namespace CarLotSimulator
{
    public class Car
    {//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //Now that the Car class is created we can instanciate 3 new cars
        //Set the properties for each of the cars
        //Call each of the methods for each car
        public Car()
        {
            CarLot.numberOfCars++;
        }
        public Car(int year, string model, string  make, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Model = model;
            Make = make;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }
        public int Year { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine(HonkNoise);
        }
        
    }
}
