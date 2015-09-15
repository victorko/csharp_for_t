using System;
using System.Collections.Generic;
using System.Linq;

namespace Examples.OOP
{
    public abstract class Polygon : Shape
    {
        protected Polygon(params Point[] vertices)
        {
            this.Vertices = vertices;
        }

        public Point[] Vertices { get; private set; }

        public override double Perimeter
        {
            get { return this.Segments.Sum(); }
        }

        public double[] Segments
        {
            get
            {
                var segments = new List<double>();
                var prevVertice = this.Vertices.First();
                foreach (var vertice in this.Vertices.Skip(1))
                {
                    segments.Add(prevVertice.DistanceTo(vertice));
                    prevVertice = vertice;
                }
                segments.Add(prevVertice.DistanceTo(this.Vertices.First()));
                return segments.ToArray();
            }
        }

        public override void Move(double dx, double dy)
        {
            foreach (var vertice in this.Vertices)
            {
                vertice.Move(dx, dy);
            }
        }
    }
}
