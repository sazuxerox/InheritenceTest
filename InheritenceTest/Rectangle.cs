using System;
using InheritenceTest;

namespace InheritenceTest
{
    class Rectangle : Shape
    {public Rectangle(double w, double h) : base(w, h)
        {
        }

        public double GetCost()
        {
            var cost = GetArea()*70;
            return cost;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("Cost is : {0:f}", GetCost());
        }
    }
}
