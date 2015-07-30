namespace Examples.ExtensionMethods
{
    class Circle : ILocated
    {
        private double x;
        private double y;
        private double r;

        private const double pi = 3.14;

        public Circle(double x, double y, double r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public double X
        {
            get { return this.x; }
        }

        public double Y
        {
            get { return this.y; }
        }

        public double R
        {
            get { return this.r; }
        }

        public double Area
        {
            get { return pi * r * r; }
        }
    }
}
