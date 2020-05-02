using System;
using System.Collections.Generic;

namespace OCPBadExample
{
    class Circle
    {   
        public static double GetArea(Double Radius)
        {
            const double PI = 3.1415926535897931;
            double result;

            result = 2 * PI * Radius;

            return result;
        }
    }

    class Triangle
    {

        public static double GetArea(Double Base, Double Height)
        {
            double result;

            result = Base * Height / 2;

            return result;
        }
    }

    class ShapesProcessor
    {
        public static void OutputAllAreasShapes(List<String> Shapes, int SizeOfList)
        {
            for (int i = 0; i < SizeOfList; i++)
            {
                if (Shapes[i] == "circle")
                    Console.WriteLine(Circle.GetArea(3.0));
                if (Shapes[i] == "triangle")
                    Console.WriteLine(Triangle.GetArea(3.0, 4.0));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<String> Shapes = new List<String>();
            Shapes.Add("circle");
            Shapes.Add("triangle");

            ShapesProcessor.OutputAllAreasShapes(Shapes, 2);
        }
    }
}
