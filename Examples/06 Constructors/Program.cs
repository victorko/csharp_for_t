using System;

namespace Examples.Constructors
{
    class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape constructor");
        }
    }

    class Point
    {
        private readonly int x;
        private readonly int y;

        public Point(int x, int y)
        {
            Console.WriteLine("Point constructor");

            this.x = x;
            this.y = y;
        }
    }

    class Rectangle : Shape
    {
        private Point position = new Point(0, 0);
        private int width;
        private int height;

        public Rectangle(int width, int height) : base()
        {
            Console.WriteLine("Rectangle constructor");

            this.width = width;
            this.height = height;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            var r = new Rectangle(5, 5);
        }
    }
}
