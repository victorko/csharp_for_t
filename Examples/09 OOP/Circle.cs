using System;

namespace Examples.OOP
{
    public class Circle : Shape
    {
        public Circle(Point center, double radius)
        {
            this.Center = center;
            this.Radius = radius;
        }

        public Point Center { get; private set; }

        public double Radius { get; private set; }

        public override double Area
        {
            get { return Math.PI * this.Radius * this.Radius; }
        }

        public override double Perimeter
        {
            get { return 2 * Math.PI * this.Radius; }
        }

        public override void Move(double dx, double dy)
        {
            this.Center.Move(dx, dy);
        }
    }
}
