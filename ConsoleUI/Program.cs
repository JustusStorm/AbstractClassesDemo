using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             *  DONE: Create an abstract class called Vehicle
             *  DONE: The vehicle class shall have three string properties Year, Make, and Model
             *  DONE: Set the defaults to something generic in the Vehicle class
             *  DONE: Vehicle shall have an abstract method called DriveAbstract with no implementation
             *  DONE: Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             *  DONE: Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             *  DONE: Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             *  DONE: Provide the implementations for the abstract methods
             *  DONE: Only in the Motorcycle class will you override the virtual drive method
            */

            // DONE: Create a list of Vehicle called vehicles

            /*
             *  DONE: Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             *  DONE: - new it up as one of each derived class
             *  DONE: Set the properties with object initializer syntax
             */

            /*
             *  DONE: Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle








            #endregion

            // Vehicle list for cars and motorcycles
            var vehicleList = new List<Vehicle>();


            
            // Creating object instances 
            Car mustang = new Car()// Instance made from explicit typing
            {
                Year = 2020,
                Make = "Ford",
                Model = "Mustang"
            };
            
            Motorcycle harley = new Motorcycle()// using explicit typing
            {
                Year = 2020,
                Make = "Harley Davidson",
                Model = "RoadHog 213"
            };

            Vehicle hoverCar = new Car()// using explicit typing
            {
                HasTrunk = false,
                Year = 2280,
                Make = "AlienWare",
                Model = "Scoot 1300"
            };

            Vehicle hoverBike = new Motorcycle()// using explicit typing
            {
                HasSideBags = false,
                Year = 2275,
                Make = "HoverBike",
                Model = "Levi 500S"
            };



            // Adding all vehicles, cars, and motorcycles to list
            vehicleList.Add(mustang);
            vehicleList.Add(harley);
            vehicleList.Add(hoverCar);
            vehicleList.Add(hoverBike);


            // Foreach loop to iterate over properties 
            foreach (var vehicle in vehicleList)
            {
                Console.WriteLine($"{vehicle.Year}, {vehicle.Make}, {vehicle.Model}, ({vehicle.GetType().Name})");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
            }
            
            

            Console.ReadLine();
           
        }
    }
}
