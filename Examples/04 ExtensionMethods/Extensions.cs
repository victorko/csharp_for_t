using System;

namespace Examples.ExtensionMethods
{
    static class Extensions
    {
        public static double DistanceTo(this Point pt1, Point pt2)
        {
            var dx = pt1.X - pt2.X;
            var dy = pt1.Y - pt2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public static double DistanceTo(this ILocated obj1, ILocated obj2)
        {
            var dx = obj1.X - obj2.X;
            var dy = obj1.Y - obj2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
