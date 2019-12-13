using PastryCalc;
using BreadCalc;
using System;
using System.Collections.Generic;
namespace Calc;
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter how much bread you would like to buy: ");
            int bread = Console.ReadLine();
            Console.WriteLine("Please enter how many pastries you would like to buy: ");
            int pastry = Console.ReadLine();
        }
    }
}