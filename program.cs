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
            int breadNum = 0;
            int pastryNum = 0;
            Console.WriteLine("Please enter how much bread you would like to buy: ");
            string bread = Console.ReadLine();
            bool breadConvert = int.TryParse(bread, out breadNum);
            Console.WriteLine("Please enter how many pastries you would like to buy: ");
            string pastry = Console.ReadLine();
            bool pastryConvert = int.TryParse(pastry, out pastryNum);
            if (breadConvert && pastryConvert && breadNum>=0 && pastryNum>=0)
            {
            Bread userBread = new Bread(breadNum);
            Pastry userPastry = new Pastry(pastryNum);
            Console.WriteLine("The total cost for bread is: $"+userBread.BreadCost()+".  The total cost for the pastries is: $"+userPastry.PastryCost());
            Console.WriteLine("Your Total is: $"+(userPastry.PastryCost()+userBread.BreadCost()));
            }
            else 
            Console.WriteLine("Please enter only whole numbers that are at least 0");
            
        }
    }
}