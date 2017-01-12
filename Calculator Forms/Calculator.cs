using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Console_Application
{
    class Calculator
    {
        public double Addition(double Num1, double Num2)
        {
            // Adds two parameters together
            double Value = Num1 + Num2;
            //Program.PreviousResult = Value;

            return Value;
        }

        public double Subtract(double Num1, double Num2)
        {
            double Value = Num1 - Num2;
            //Program.PreviousResult = Value;

            return Value;
        }

        public double Multiply(double Num1, double Num2)
        {
            double Value = Num1*Num2;
            //Program.PreviousResult = Value;

            return Value;
        }

        public double Divide(double Num1, double Num2)
        {
            double Value = Num1/Num2;
            //Program.PreviousResult = Value;

            return Value;
        }

        // Checks if Character is an operand
        public bool DetermineIfOperand(string character)
        {
            switch (character)
            {
                case "/":
                    return true;
                case "*":
                    return true;
                case "+":
                    return true;
                case "-":
                    return true;
                case "sqrt":
                    return true;
                case "random":
                    return true;
                default:
                    return false;
            }

        }
    }
}
    


