using System;

namespace PastryCalc;
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
        }
    }
    
}