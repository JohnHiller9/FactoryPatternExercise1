using System;
namespace FactoryPatternExercise1
{
    public class Motorcycle : IVehicleWheels
    {
        public Motorcycle()
        {
        }

        public void Build()
        {
            ConsoleLogger.VehicleStartUp();
            Console.WriteLine("The motorcycle is driving.");
        }
    }
}
