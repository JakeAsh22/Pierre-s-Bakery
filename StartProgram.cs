using PastryCalc;
using BreadCalc;
using Calc;
using System;
using System.Collections.Generic;

namespace StartProgram
{
    class Start
    {
        public static void StartsProgram()
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
                Bread userBread = new Bread();
                userBread.SetBread(breadNum);
                Pastry userPastry = new Pastry();
                userPastry.SetPastry(pastryNum);
                Console.WriteLine("\nThe total cost for bread is: $"+userBread.GetBreadCost()+".  The total cost for the pastries is: $"+userPastry.GetPastryCost());
                Console.WriteLine("Your Total is: $"+(userPastry.GetPastryCost()+userBread.GetBreadCost()));
            }
            else 
                Console.WriteLine("Please enter only whole numbers that are at least 0");
        }
    }
}