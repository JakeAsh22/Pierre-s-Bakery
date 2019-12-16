using System;
using System.Collections.Generic;
using Calc;
namespace PastryCalc
{
    class Pastry
    {
        private int _pastryAmt;
        private int _cost = 0;

        private void PastryCost()
        {
            int pastry = 2;
            if (_pastryAmt % 3 == 0)
            {
                _cost = (_pastryAmt/3)*5;
            }
            else if (_pastryAmt<3)
            {
                _cost = pastry*_pastryAmt;
            }
            else 
            {
                if ((_pastryAmt-1) % 3 == 0)
                {
                    _cost = ((_pastryAmt-1)/3)*5+pastry;
                }
                else 
                {
                    _cost = ((_pastryAmt-1)/3)*5+(pastry*2);
                }
            }
        }

        public int GetPastryCost()
        {
            PastryCost();
            return _cost;
        }

        public void SetPastry(int pastryAmt)
        {
             _pastryAmt = pastryAmt;
        }

    }
    
}