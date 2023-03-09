using System;

namespace Constructor
{
    class Vehicle
    {
        int wheels;
        Vehicle()
        {
            wheels = 4;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Vehicle car = new Vehicle();
                Console.Write(car.wheels);

            }
        }
    }
}

