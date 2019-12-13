using PastryCalc;
using BreadCalc;
using System;
using System.Collections.Generic;
namespace Calc
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter how much bread you would like to buy: ");
            int bread = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter how many pastries you would like to buy: ");
            int pastry = int.Parse(Console.ReadLine());
            Bread userBread = new Bread(bread);
            Pastry userPastry = new Pastry(pastry);
            Console.WriteLine("The total cost for bread is: $"+userBread.BreadCost()+".  The total cost for the pastries is: $"+userPastry.PastryCost());
            Console.WriteLine("Your Total is: $"+(userPastry.PastryCost()+userBread.BreadCost()));
        }
    }
}