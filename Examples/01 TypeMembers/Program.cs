using System;

namespace Examples.TypeMembers
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 1
            Point p1 = new Point(1, 1);
            Point p2 = new Point(2, 2);
            Point p3 = p1 + p2;

            // 2
            Point p4 = new Point(2, 3.5);
            string s = (string)p4;

            // 3
            Point p5 = new Point(5, 5);
            p5.Move(1, 1);
            p5.PointMoved += OnPointMoved;
            p5.Move(1, 1);
            p5.PointMoved -= OnPointMoved;
            p5.Move(1, 1);
        }

        static void OnPointMoved(Point point, double originalX, double originalY)
        {
            Console.WriteLine("Move from ({0}, {1}) to {2}", originalX, originalY, point);
        }
    }
}
