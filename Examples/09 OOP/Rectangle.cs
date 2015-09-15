namespace Examples.OOP
{
    public class Rectangle : Polygon
    {
        public Rectangle(Point p1, Point p2, Point p3, Point p4) 
            : base(p1, p2, p3, p4)
        {
            // проверить на перпендикулярность сторон
        }

        public override double Area
        {
            get
            {
                var segments = this.Segments;
                return segments[0] * segments[1];
            }
        }
    }
}
