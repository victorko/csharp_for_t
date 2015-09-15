using System;

namespace Examples.OOP
{
    public class Point : IMovable
    {
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; private set; }

        public double Y { get; private set; }

        public void Move(double dx, double dy)
        {
            this.X += dx;
            this.Y += dy;
        }

        public double DistanceTo(Point that)
        {
            var dx = this.X - that.X;
            var dy = this.Y - that.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
