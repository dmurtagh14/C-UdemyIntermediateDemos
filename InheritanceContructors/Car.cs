using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceContructors
{
    class Car: Vehicle
    {
        public Car()
            :base() //use :base to access constructor from super class
        {
            Console.WriteLine("Car is being initlaized");
        }

        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine("Car is being intiilzed, {0}", registrationNumber);
        }
    }
}
