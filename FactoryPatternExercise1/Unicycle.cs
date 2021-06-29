using System;
namespace FactoryPatternExercise1
{
    public class Unicycle : IVehicleWheels
    {
        public Unicycle()
        {
        }

        public void Build()
        {
            ConsoleLogger.VehicleStartUp();
            Console.WriteLine("The unicycle is driving.");
        }
    }
}
