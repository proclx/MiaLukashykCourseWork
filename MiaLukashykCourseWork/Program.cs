using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MiaLukashykCourseWork
{
    internal class Program
    {
        class CompareConeByVolume : IComparer<Point>
        {
            public int Compare(Point x, Point y)
            {
                return (y as Cone).Volume().CompareTo((x as Cone).Volume());
            }
        }
        static void Main(string[] args)
        {
            Point[] points = {
                new Cone(new Circle(new Point(), 25), 10),
                new Cone(new Circle(new Point(), 10), 15),
                new Cone(new Circle(new Point(), 15), 5),
                new Cone(new Circle(new Point(), 5), 20),
                new Cone(new Circle(new Point(), 20), 25),
            };
            Cone highestCone = points[0] as Cone;
            foreach (Point p in points)
            {
                if(p is Cone c && c.H > highestCone.H)
                {
                    highestCone = c;
                }
            }
            Console.WriteLine($"highest cone = {highestCone}");
            Array.Sort(points, new CompareConeByVolume());
            Console.WriteLine("--- Sorted collection ---");
            foreach (Point p in points)
            {
                Console.WriteLine($"Cone {p} Volume {(p as Cone).Volume()}");
            }

            string file = "C:\\Users\\iprot\\source\\repos\\MiaLukashykCourseWork\\MiaLukashykCourseWork\\cones.txt";
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Point p in points)
                {
                    writer.WriteLine($"Cone {p} Volume {(p as Cone).Volume()}");

                }
            }
        }
    }
}
