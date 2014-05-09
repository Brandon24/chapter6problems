using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToYards.cs
{
    class Program
    {
        public static void totalFeet(int inches)
        {
            int feet, inch;
            feet = inches / 12;
            inch = inches % 12;
            Console.WriteLine("{0} Feet and {1} Inches", feet, inch);
        }
        static void Main(string[] args)
        {
            int inches = 67;
            totalFeet(inches);
        }
    }
}
