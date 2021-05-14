using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class BaseMath
    {
        public double Sum(double a,double b)
        {
            return a + b;
        }
        public double Substract(double a, double b)
        {
            return a - b;
        }
        public double Product(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a , double b)
        {
            return a / b;
        }
        public double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }
    }
}
