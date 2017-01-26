using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calculator_Forms
{
    class Calculator
    {
        // Number 1 and 2 which is used in all of the calculation methods.
        protected double Num1;
        protected double Num2;

        public void AssignFirstNumber(double value)
        {
            if (Regex.IsMatch(value.ToString(), "[0-9]"))
                Num1 = value;
        }

        public void AssignSecondNumber(double value)
        {
            if (Regex.IsMatch(value.ToString(), "[0-9]"))
                Num2 = value;
        }

        // Adds two numbers together
        public double Addition()
        { 
            double value = Num1 + Num2;

            return value;
        }

        // Subtracts two numbers
        public double Subtract()
        {
            double value = Num1 - Num2;

            return value;
        }

        // Multiplies two numbers
        public double Multiply()
        {
            double value = Num1 * Num2;

            return value;
        }

        // Divides two numbers
        public double Divide()
        {
            double value = Num1 / Num2;

            return value;
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
                case "√":
                    return true;
                case "random":
                    return true;
                default:
                    return false;
            }
        }

        public string FindCurrentVersion()
        {
            return CurrentVersion();
        }

        // Testing virtual and override: Will return which ever class is used to initialize this method
        protected virtual string CurrentVersion()
        {
            return "Calculator";

        }
    }
}
    


