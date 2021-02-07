using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 1; //setting default is adding = to end of method with a value
                                           //whereas methods otherwise end in (); (they are parameterless)
        public string Make { get; set; } = "Generic Make";
        public string Model { get; set; } = "Generic Model";

        public abstract void DriveAbstract(); //"stubbed" out / Abstract method 
                                              //doesn't have implentation / get set / scope / brackets
                                              //doesn't have stuff to do
                                              //(void) not returning anything (except poss later CWL)
                                              //there are parens with semicolon-this is how it's done
                                              //for no implementation / empty parentheses and semicolon

        public virtual void DriveVirtual() //create a base implementation fr imagination
                                           //other classes inheriting from Vehicle can override this scope
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive.");
        }

    }
}
