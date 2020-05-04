using System;

namespace LPBadExample
{

    class Rectangle
    {
        public double Height;
        public double Width;

        public void AssignAttributes(double Height, double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }
    }

    class Square : Rectangle
    {
        public void AssignAttributese(double Height, double Width)
        {
            this.Height = Height;
            this.Width = Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Square square = new Square();

            rectangle.AssignAttributes(3, 4);
            square.AssignAttributes(3, 3);
        }
    }
}
