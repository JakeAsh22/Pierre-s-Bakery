using System;
using System.Collections.Generic;
using Calc;
namespace BreadCalc
{
 class Bread
 {
    private int _breadAmt;
    private int _cost = 0;
    
    private void BreadCost()
    {
        int bread = 5;
        
        if (_breadAmt % 3 == 0)
        {
            _cost =  (bread*_breadAmt)-((_breadAmt/3)*bread);
        }
        else if (_breadAmt<3)
        {
            _cost =  bread*_breadAmt;
        }
        else 
        {
            if ((_breadAmt-1) % 3 == 0)
            {
                _cost = (bread*(_breadAmt-1))-((_breadAmt/3)*bread)+bread;
            }
            else
            {
                _cost = (bread*(_breadAmt-2))-((_breadAmt/3)*bread)+(bread*2);
            }
        }
    }

    public int GetBreadCost()
    {
        BreadCost();
        return _cost;
    }

    public void SetBread(int breadAmt)
    {
        _breadAmt = breadAmt;
    }
 }   
}