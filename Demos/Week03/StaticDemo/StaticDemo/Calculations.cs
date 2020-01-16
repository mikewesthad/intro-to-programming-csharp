using System;
using System.Collections.Generic;
using System.Text;

namespace StaticDemo
{
    // A collection of static methods for mathematical calculations.
    class Calculations
    {
        // fullPrice is the cost of an item and discountPercent is a number between 0 - 100 to 
        // represent the % off.
        static public double CalculateSalePrice(double fullPrice, double discountPercent) 
        {
            double discount = fullPrice * (discountPercent / 100);
            return fullPrice - discount;
        }

    }
}
