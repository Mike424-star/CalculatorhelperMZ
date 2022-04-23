using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatorhelper.MZ.Calculator
{
    public class Divide : ICalculate
    {
        public void Calculate(double a, double b)
        {
            Console.WriteLine("a/b is {0}", a / b);
        }
    }
}
