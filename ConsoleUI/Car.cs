using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {

        }

        public bool HasTrunk { get; set; } = true;
        public override void DriveAbstract()
        {
            /* when ***throw new NotImplementedException();***
             * message appears, we need to add implementation
             * it is bc it's from stubbed out method which has no scope */

            Console.WriteLine("This car has a smooth ride.");
        }
    }
}
