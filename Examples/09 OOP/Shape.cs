namespace Examples.OOP
{
    public abstract class Shape : IMovable
    {
        public abstract double Area { get; }

        public abstract double Perimeter { get; }

        public abstract void Move(double dx, double dy);
    }
}
