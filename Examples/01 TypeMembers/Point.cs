using System;

namespace Examples.TypeMembers
{
    class Point
    {
        // константа
        private const string STRING_FORMAT = "({0}, {1})";

        // поля
        private double x;
        private double y;

        // конструктор
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // свойство
        public double X
        {
            get { return this.x; }
        }

        // свойство
        public double Y
        {
            get { return this.y; }
        }

        // индексатор
        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return this.x;
                    case 1:
                        return this.y;
                    default:
                        throw new NotSupportedException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        this.x = value;
                        break;
                    case 1:
                        this.y = value;
                        break;
                    default:
                        throw new NotSupportedException();
                }
            }
        }

        // метод
        public void Move(double dx, double dy)
        {
            var originalX = this.x;
            var originalY = this.y;

            this.x += dx;
            this.y += dy; 

            if (this.PointMoved != null)
            {
                this.PointMoved(this, originalX, originalY);
            }
        }

        // метод
        public override string ToString()
        {
            return string.Format(STRING_FORMAT, this.x, this.y);
        }



        // оператор +
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

        // оператор приведения
        public static explicit operator String(Point p)
        {
            return p.ToString();
        }


        // вложенный делегат
        public delegate void PointMovedHandler(Point point, double originalX, double originalY);

        // событие
        public event PointMovedHandler PointMoved;
    }
}
