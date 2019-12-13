using System;
using System.Collections.Generic;
using Calc;
namespace PastryCalc
{
    class Pastry
    {
        private int _pastryAmt;

        public Pastry (int pastryAmt)
        {
            _pastryAmt = pastryAmt;
        }

        public int PastryCost()
        {
            int pastry = 2;
            if (_pastryAmt % 3 == 0)
            {
                return (_pastryAmt/3)*5;
            }
            else if (_pastryAmt<3)
            {
                return pastry*_pastryAmt;
            }
            else 
            {
                if ((_pastryAmt-1) % 3 == 0)
                {
                    return ((_pastryAmt-1)/3)*5+pastry;
                }
                else 
                {
                    return ((_pastryAmt-1)/3)*5+(pastry*2);
                }
            }
        }
    }
    
}