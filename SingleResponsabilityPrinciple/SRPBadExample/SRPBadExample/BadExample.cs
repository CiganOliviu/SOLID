using System;
using calculation_structures;

namespace SRP
{
    class Equations
    {
        public double GetRootLinearEquation(linearEquation Equation)
        {
            double Root = 0;

            if (Equation.slope.Equals(0))
                throw new System.ArgumentException("Slope can not be zero");
            if (Equation.y_intercept.Equals(0))
                throw new System.ArgumentException("y intercept can not be zero");

            Root = -Equation.y_intercept / Equation.slope;

            return Root;
        }

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
            Equations EquationsMethods = new Equations();
            limits<double> Roots = new limits<double>();

            Linear.slope = 5;
            Linear.y_intercept = 7;

            Console.WriteLine(EquationsMethods.GetRootLinearEquation(Linear));

            Quadratic.coefficient_a = 1;
            Quadratic.coefficient_b = 4;
            Quadratic.coefficient_c = 3;

            Roots.minimLimit = -3;
            Roots.maximLimit = -1;

            Console.WriteLine(EquationsMethods.GetValueQuadraticEquation(Quadratic, Roots));
        }
    }
}