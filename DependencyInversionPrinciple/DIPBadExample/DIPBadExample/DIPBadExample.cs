using System;
using calculation_structures;

namespace DIPBadExample
{
    class LinearEquationMath
    {
        public float GetValueLinearEquation ()
        {
            linearEquation Equation = new linearEquation();

            float Result;

            Result = (Equation.slope * Equation.root) + Equation.y_intercept;

            return Result;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            LinearEquationMath LEMath = new LinearEquationMath();

            LEMath.GetValueLinearEquation();
        }
    }
}
