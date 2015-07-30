using System;

namespace Examples.Props
{
    class Circle
    {
        private int x;
        private int y;

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public int R { get; set; }

        //public int get_R()
        //{
        //    return 0;
        //}
        //public void set_R(int value)
        //{
        //}

        public int this[int dimension]
        {
            get
            {
                switch (dimension)
                {
                    case 1:
                        return this.x;
                    case 2:
                        return this.y;
                    default:
                        throw new ArgumentException("Wrong dimension");
                }
            }
            set
            {
                switch (dimension)
                {
                    case 1:
                        this.x = value;
                        break;
                    case 2:
                        this.y = value;
                        break;
                    default:
                        throw new ArgumentException("Wrong dimension");
                }
            }
        }

        //public int get_Item(int dimension)
        //{
        //    return 0;
        //}
        //public void set_Item(int dimension, int value)
        //{
        //}
    }
}
