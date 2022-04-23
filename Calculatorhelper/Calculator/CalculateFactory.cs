using Calculator.helper.MZ21.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatorhelper.MZ.Calculator
{
    public class CalculateFactory
    {
        public ICalculate GetCalculate(string type)
        {
            ICalculate obj = null;

            if (type.ToLower().Equals("add"))
            {
                obj = new Add();
            }
            else if (type.ToLower().Equals("Subtract"))
            {
                obj = new Subtract();
            }
             else if (type.ToLower().Equals("divide"))
            {
                obj = new Divide();
            }
            else if (type.ToLower().Equals("Multiplicate"))
            {
                obj = new Multiplicate();
            }
            else
            {
                Console.WriteLine("We dont do that");
            }

            return obj; 
        }
    }
}
