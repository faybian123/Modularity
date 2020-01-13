using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculator
    {
        //This is a calculator class and below are the member functions:

        //Addition Function
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        //Subtraction Function
        //Basic validation added to ensure that we subtract the smaller number from the larger number
        public double Subtract(double num1, double num2)
        {
            if (num1 > num2)
            {
                return num1 - num2;
            }
            return num2 - num1;
        }

        //Multiplication Function
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        //Division Function
        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }









    }
}
