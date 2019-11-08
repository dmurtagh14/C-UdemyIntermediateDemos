using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceContructors
{
    class Vehicle
    {
        private readonly string _registrationNumber;

        public Vehicle()
        {
            Console.WriteLine("Vehicale is being intitilaized");
        }

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being intiilzed, {0}", registrationNumber);
        }
    }
}
