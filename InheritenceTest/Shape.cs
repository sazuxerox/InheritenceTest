using System;

namespace InheritenceTest
{
    class Shape
    {
        protected double Width;
        protected double Height;

        public Shape(double w, double h)
        {
            Width = w;
            Height = h;
        }

        public double GetArea()
        {
            return (Width*Height);
        }

        public void Display()
        {
            Console.WriteLine("Width is : {0:F1}", Width);
            Console.WriteLine("Height is : {0:F1}", Height);
            Console.WriteLine("Area is : {0:f2}", GetArea());
        }
    }
}
