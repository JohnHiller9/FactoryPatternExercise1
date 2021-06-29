using System;
namespace FactoryPatternExercise1
{
    public class Car : IVehicleWheels
    {
        public Car()
        {
        }
        public void Build()
        {
            ConsoleLogger.VehicleStartUp();
            Console.WriteLine("The car is driving.");
        }
    }
}
