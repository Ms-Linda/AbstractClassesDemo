using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {

        public bool HasSideCart { get; set; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("This special Motorcycle has a smooth and quiet ride.");
        }
        public override void DriveVirtual()
        {
            //***base.DriveVirtual();*** 
            //this message appeared bc inherited from Vehicle
            //gets overridden by deleting it; then we make our own with CWL
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that is virtually a smooth, quiet ride.");
        }

    }
}
