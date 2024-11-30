using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLukashykCourseWork
{
    public class Cone
        : Circle
    {
        private double height;
        public double H { get { return height; } set { height = Math.Abs(value); } }
        public Cone(double centerX = 0, double centerY = 0, double radius = 0, double height = 0)
            : base(centerX, centerY, radius)
        {
            H = height;
        }
        public Cone(Point p, double radius = 0, double height = 0)
            : base(p, radius)
        {
            H = height;
        }
        public Cone(Circle c, double height = 0)
            : base(c)
        {
            H = height;
        }
        public Cone(Cone other)
            : base(other)
        {
            H = other.H;
        }
        public void MultiplyHeightBy(double coef)
        {
            H *= Math.Abs(coef);
        }
        public double Volume()
        {
            double h = Math.PI*R*R*(H/3);
            return h;
        }
        public double SurfaceArea()
        {
            double l = Math.Sqrt(R * R + H * H);
            double s = Math.PI * R * l;
            return s;
        }
        public override double Area()
        {
            double a = base.Area() + SurfaceArea();
            return a;
        }
        public static Cone operator*(Cone c, double coeff)
        {
            return new Cone((Circle)c * coeff, c.H * coeff);
        }
        public override string ToString()
        {
            return $"h = {H}; {base.ToString()}";
        }
    }
}
