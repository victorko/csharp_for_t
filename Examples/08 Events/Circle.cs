namespace Examples.Events
{
    class Circle
    {
        private int x;
        private int y;
        private int r;

        public delegate void MoveHandler(int oldX, int oldY, int newX, int newY);

        public event MoveHandler Moved;

        public int X
        {
            get { return this.x; }
            set
            {
                var oldX = this.x;
                this.x = value;
                if (this.Moved != null)
                    this.Moved(oldX, this.y, this.x, this.y);
            }
        }

        public int Y
        {
            get { return this.y; }
            set
            {
                var oldY = this.y;
                this.y = value;
                if (this.Moved != null)
                    this.Moved(this.x, oldY, this.x, this.y);
            }
        }

        public delegate void ResizeHandler(int oldR, int newR);

        public event ResizeHandler Resized;

        public int R
        {
            get { return this.r; }
            set
            {
                var oldR = this.r;
                this.r = value;
                if (this.Resized != null)
                    this.Resized(oldR, this.r);
            }
        }
    }
}
