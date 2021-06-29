using System;
using System.Threading;
namespace FactoryPatternExercise1
{
    public class ConsoleLogger
    {
        public static void VehicleStartUp()
        {
            Console.WriteLine("Gathering phone tools.");
            Thread.Sleep(1000);
            Console.WriteLine("Turn key!");
            Thread.Sleep(1000);
        }
    }
}
