using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    abstract class Vehicle
    {

        private int totalNumberOfVehicles;


        // Properties 
        public int Year { get; set; } = 0;
        public string Make { get; set; } = "N/A";
        public string Model { get; set; } = "N/A";
        





        // Methods
        public abstract void DriveAbstract(); // Stubbed Out Method


        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive.");
        }

        




        


    }
}
