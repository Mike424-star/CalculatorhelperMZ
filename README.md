# CalculatorhelperMZ

This Nuget package is a calculator specificly made for the console application to smooth out the process of using calculation processes and instead of writing the whole code to add and subtract for example its is already done in the libary classes the user is only need to put the variables in such as the subtract,add , divide and multiplication. 

# Enviroment 
Console Application

# Design Pattern
Factory pattern 

# Nuget Package:
This will provide the coder when the console applications start it will ask for two numbers and what process the coder wants to use. 
This is a way for the coder to easily access the calculator in the console application and execute several processes at the time.

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



# Nuget Package Link

https://www.nuget.org/packages/Calculator.helper.MZ21/1.0.0
