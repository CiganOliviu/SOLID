using System;

namespace ISPBadExample
{

    interface ShapesAttributes
    {
        double GetArea();
        double GetVolume();
    }

    class Cube : ShapesAttributes
    {

        private double Width;
        public void SetWidth (double Width)
        {
            this.Width = Width;
        }
        public double GetArea()
        {
            double Result;

            Result = 6 * Math.Pow(Width, 2);

            return Result;
        }
        public double GetVolume()
        {
            double Result;

            Result = Math.Pow(Width, 3);

            return Result;
        }
    }

    class Triangle : ShapesAttributes
    {
        private double Base;
        private double Height;
        
        public void SetTriangleAttributes (double Base, double Height)
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

        public double GetVolume()
        {
            double Result = 0.0;

            return Result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            triangle.GetVolume();
        }
    }
}
