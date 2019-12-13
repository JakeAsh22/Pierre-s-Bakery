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

        if (_breadAmt % 2 == 0)
        {
            return (bread*_breadAmt)/2;
        }
        else if (_breadAmt == 1)
        {
            return bread;
        }
        else 
        {
            return (bread*(_breadAmt-1))/2+bread;
        }
    }
 }   
}