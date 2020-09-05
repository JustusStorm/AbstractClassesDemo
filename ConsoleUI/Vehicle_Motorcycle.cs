using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        // Properties 
        public bool HasSideBags { get; set; } = true;
        public int Wheels { get; set; } = 2;


        // Constructors
        
        public Motorcycle()
        {
            
        }




        // Methods
        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle is in drive.");
            
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This DriveVirtual method has been overridden by the Motorcycle class.");
            
        }
    }
}
