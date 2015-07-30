using System;

namespace Examples.Events
{
    class Program
    {
        public static void Main(string[] args)
        {
            var c = new Circle();

            c.Moved += OnMove;
            c.Resized += OnResize;

            c.X = 2;
            c.Y = 3;
            c.R = 5;
        }

        static void OnMove(int oldX, int oldY, int newX, int newY)
        {
            Console.WriteLine("Move: ({0}, {1}) --> ({2}, {3})", oldX, oldY, newX, newY);
        }

        static void OnResize(int oldR, int newR)
        {
            Console.WriteLine("Resize: {0} --> {1}", oldR, newR);
        }
    }
}
