using System;
using System.Collections.Generic;
using Calc;
namespace BreadCalc
{
 class Bread
 {
    private int _breadAmt;

    public Bread (int breadAmt)
    {
        _breadAmt = breadAmt;
    }   

    public int BreadCost()
    {
        int bread = 5;

        if (_breadAmt % 3 == 0)
        {
            return (bread*_breadAmt)-((_breadAmt/3)*bread);
        }
        else if (_breadAmt<3)
        {
            return bread*_breadAmt;
        }
        else 
        {
            if ((_breadAmt-1) % 3 == 0)
            {
                return (bread*(_breadAmt-1))-((_breadAmt/3)*bread)+bread;
            }
            else
            {
                return (bread*(_breadAmt-2))-((_breadAmt/3)*bread)+(bread*2);
            }
        }
    }
 }   
}