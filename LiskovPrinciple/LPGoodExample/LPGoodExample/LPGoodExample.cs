using System;

namespace LPGoodExample
{
    class Rectangle
    {
        double Height;
        double Width;
        public void AssignAttributes(double Height, double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }
    }

    class Square
    {
        double Height;

        public void AssignAttributes(double Height)
        {
            this.Height = Height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Square square = new Square();

            rectangle.AssignAttributes(3, 4);
            square.AssignAttributes(3);
        }
    }
}
