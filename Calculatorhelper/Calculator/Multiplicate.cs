using Calculatorhelper.MZ.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.helper.MZ21.Calculator
{
    public class Multiplicate : ICalculate
    {
        public void Calculate(double a, double b)
        {
            Console.WriteLine("a*b is {0}", a * b);
        }
    }
}
