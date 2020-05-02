using System;

namespace OCPGoodExample
{
    interface Shapes
    {
        double GetArea();
    }

    class Circle: Shapes
    {

        private const double PI = 3.1415926535897931;
        public double Radius;

        public Circle (double Radius)
        {
            this.Radius = Radius;
        }
        public double GetArea()
        {
            double Result;

            Result = 2 * PI * Radius;

            return Result;
        }
    }

    class Triangle: Shapes
    {
        double Base;
        double Height;
        
        public Triangle (double Base, double Height)
        {
            this.Base = Base;
            this.Height = Height;
        } 
        public double GetArea ()
        {
            double Result;

            Result = Base * Height / 2;

            return Result;
        }
    }

    class ShapesProcessor
    {
        public static void OutputAllAreasShapes (Shapes[] ShapeInstances, int SizeOfArray)
        {
            for (int i = 0; i < SizeOfArray; i++)
            {
                Console.WriteLine(ShapeInstances[i].GetArea());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shapes[] ShapeInstance = new Shapes[2];
            
            ShapeInstance[0] = new Circle(3.0);
            ShapeInstance[1] = new Triangle(3.0, 4.0);
            
            int Size = 2;

            ShapesProcessor.OutputAllAreasShapes(ShapeInstance, Size);
        }
    }
}
