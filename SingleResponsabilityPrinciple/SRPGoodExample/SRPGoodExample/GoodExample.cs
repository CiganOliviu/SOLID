using System;
using calculation_structures;

namespace SRP
{
    class Validations
    {
        public void CheckIfZero<Type> (Type Value)
        {
            if (Value.Equals(0))
                throw new System.ArgumentException("Cannot work with parameters assigned to 0");
        }
    }

    class LinearEquationOperations
    {
        public double GetRootLinearEquation(Validations validations, linearEquation Equation)
        {
            validations.CheckIfZero<double>(Equation.slope);
            validations.CheckIfZero<double>(Equation.y_intercept);

            double Root = 0;

            Root = -Equation.y_intercept / Equation.slope;

            return Root;
        }
    }
    
    class QuadraticEquationOperations
    {
        public double GetValueQuadraticEquation(quadraticEquation Equation, limits<double> Roots)
        {
            double Result;

            Result = ((Equation.coefficient_a * Math.Pow(Roots.minimLimit, 2) + (Equation.coefficient_b * Roots.maximLimit) + (Equation.coefficient_c)));

            return Result;
        }
    }


    class BadExample
    {
        static void Main(string[] args)
        {
            linearEquation Linear = new linearEquation();
            quadraticEquation Quadratic = new quadraticEquation();

            Validations validations = new Validations();

            LinearEquationOperations LinearOperations = new LinearEquationOperations();
            QuadraticEquationOperations QuadraticOperations = new QuadraticEquationOperations();

            limits<double> Roots = new limits<double>();

            Linear.slope = 5;
            Linear.y_intercept = 7;

            Console.WriteLine(LinearOperations.GetRootLinearEquation(validations, Linear));

            Quadratic.coefficient_a = 1;
            Quadratic.coefficient_b = 4;
            Quadratic.coefficient_c = 3;

            Roots.minimLimit = -3;
            Roots.maximLimit = -1;

            Console.WriteLine(QuadraticOperations.GetValueQuadraticEquation(Quadratic, Roots));
        }
    }
}
