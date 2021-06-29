using System;
namespace FactoryPatternExercise1
{
    public class Rickshaw : IVehicleWheels
    {
        public Rickshaw()
        {
        }

        public void Build()
        {
            ConsoleLogger.VehicleStartUp();
            Console.WriteLine("The rickshaw is driving.");
        }
    }
}
