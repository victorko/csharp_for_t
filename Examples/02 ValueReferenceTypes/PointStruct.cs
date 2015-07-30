
namespace Examples.ValueReferenceTypes
{
    struct PointStruct
    {
        #region Состояние объекта
        
        private double x;
        private double y; 
        
        #endregion

        #region Поведение объекта

        public PointStruct(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return this.x; }
        }

        public double Y
        {
            get { return this.y; }
        }

        public void Move(double dx, double dy)
        {
            this.x += dx;
            this.y += dy;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", this.x, this.y);
        } 

        #endregion
     }
}
