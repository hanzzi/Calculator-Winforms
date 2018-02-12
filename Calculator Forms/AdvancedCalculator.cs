using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator_Forms
{
    class AdvancedCalculator : BaseCalculator
    {
        #region Formulas
        // Calculates the power of Num1 with Num2
        public double Power()
        {
            double value = Math.Pow(Num1, Num2);

            return value;
        }

        // gets the square root of a number
        public double SquareRoot()
        {
            double value = Math.Sqrt(Num1);

            return value;
        }

        // gets a random number between num1 and num2
        public double Random()
        {
            int iNum1;
            int iNum2;
            Random rnd = new Random();

            int.TryParse(Num1.ToString(CultureInfo.CurrentCulture), out iNum1);
            int.TryParse(Num2.ToString(CultureInfo.CurrentCulture), out iNum2);

            double value = rnd.Next(iNum1, iNum2);

            return value;
        }
#endregion

        protected override string CurrentVersion()
        {
            return "Advanced Calculator";
        }

        //  Very interesting
    }
}
