using System;
using algo_data_structures;

namespace DIPGoodExample
{

    class LinearEquationMath
    {
        public float GetValueLinearEquation (linearEquation Equation)
        {
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
            linearEquation Equation = new linearEquation();

            LEMath.GetValueLinearEquation(Equation);
        }
    }
}
