using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MiaLukashykCourseWork
{
    public class Circle
        : Point
    {
        private double radius;
        public double R
        {
            get { return radius; } 
            set
            {
                if (value < 0)
                {
                    radius = 0;
                    throw new Exception("Radius can't be negative");
                }
                radius = value;
            }
        }
        public Circle(double centerX = 0, double centerY = 0, double radius = 0)
            : base(centerX, centerY)
        {
            R = radius;
        }
        public Circle(Circle other)
            : base(other)
        {
            R = other.R;
        }
        public Circle(Point p, double radius = 0)
            : base(p)
        {
            R = radius;
        }
        public void MultiplyRadiusBy(double coef)
        {
            R *= Math.Abs(coef);
        }
        public static Circle operator*(Circle c, double coeff)
        {
            return new Circle((Point)c * coeff, c.R * coeff);
        }
        public virtual double Area()
        {
            double r = Math.PI * R * R;
            return r;
        }
        public override string ToString()
        {
            return $"r = {R}; center = {base.ToString()}";
        }
    }
}
