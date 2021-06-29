using System;
namespace FactoryPatternExercise1
{
    public static class VehicleFactory
    {
        public static IVehicleWheels GetVehicle(int wheelcount)
        {
            switch (wheelcount)
            {
                case 1:
                    return new Unicycle();
                case 2:
                    return new Motorcycle();
                case 3:
                    return new Rickshaw();
                case 4:
                    return new Car();    
                default:
                    return new Car();

            }



        }
    }
}
