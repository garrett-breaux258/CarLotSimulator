using System;
namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool isDriveable { get; set; }

        public void MakeEngineNoise ()
        {
            Console.WriteLine($"Your {Year} {Make} {Model} engine sound's {EngineNoise}");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"Your {Year} {Make} {Model} honk sound's {HonkNoise}");
        }
    }

}
