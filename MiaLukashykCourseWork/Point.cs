using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLukashykCourseWork
{
    public class Point
    {
        private double x;
        private double y;
        public Point(double x = 0.0, double y = 0.0)
        {
            this.x = x;
            this.y = y;
        }
        public Point(Point other)
        {
            x = other.x;
            y = other.y;
        }
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public static Point operator *(Point a, double coef)
        {
            Point result = new Point(a.X*coef, a.Y*coef);
            return result;
        }
        public override string ToString()
        {
            return $"({X}; {Y})";
        }
    }
}
