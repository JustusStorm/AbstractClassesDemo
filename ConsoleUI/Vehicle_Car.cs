using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car : Vehicle
    {

        // Properties
        public bool HasTrunk { get; set; } = true;
        public int Wheels { get; set; } = 4;




        // Constructor
        public Car()
        {
            
        }




        // Methods

        public override void DriveAbstract()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that is virtually in drive.");
        }
    }
}
