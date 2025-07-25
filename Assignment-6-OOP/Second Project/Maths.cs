using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_OOP.Second_Project
{
    public static class Maths
    {
        public static double add(double a, double b)
        {
            return a + b;
        }
        public static double subtract(double a, double b)
        {
            return a - b;
        }
        public static double multiply(double a, double b)
        {
            return a * b;
        }
        public static double divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            return a / b;
        }

    }
}
