namespace Examples.ExtensionMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            var pt1 = new Point(0, 0);
            var pt2 = new Point(3, 4);

            var d = pt1.DistanceTo(pt2);

            var circ = new Circle(3, 4, 5);

            var d2 = pt1.DistanceTo(circ);
            var d3 = circ.DistanceTo(pt2);
        }
    }
}
