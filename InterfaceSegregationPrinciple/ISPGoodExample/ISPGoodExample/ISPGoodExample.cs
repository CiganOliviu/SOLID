using System;

namespace ISPGoodExample
{
    interface ShapeAttributes
    {
        double GetArea();
    }
    interface SolidShapesAttribute
    {
        double GetVolume();
    }

    class Cube : SolidShapesAttribute
    {
        private double Width;
        
        public void SetWidth(double Width)
        {
            this.Width = Width;
        }
        public double GetVolume()
        {
            double Result;

            Result = Math.Pow(Width, 3);

            return Result;
        }
    }

    class Triangle : ShapeAttributes
    {
        private double Base;
        private double Height;

        public void SetTriangleAttributes(double Base, double Height)
        {
            this.Base = Base;
            this.Height = Height;
        }

        public double GetArea()
        {
            double Result;

            Result = (Base * Height) / 2;

            return Result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cube cube = new Cube();
            Triangle triangle = new Triangle();

            cube.GetVolume();
            triangle.GetArea();
        }
    }
}
