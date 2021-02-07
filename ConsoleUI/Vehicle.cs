using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Generic Make";
        public string Model { get; set; } = "Generic Model";

        public abstract void DriveAbstract(); //"stubbed" out / Abstract method 
                                              //doesn't have implentation / get set / scope
                                              //there are parens with semicolon-this is how it's done
                                              //for no implementation / empty parentheses and semicolon



    }
}
