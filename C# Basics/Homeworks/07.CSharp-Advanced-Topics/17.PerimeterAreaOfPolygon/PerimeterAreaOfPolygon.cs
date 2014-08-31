using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PerimeterAreaOfPolygon
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    class Polygon
    {
        public static double Area(Point[] p, int n)
        {
            double area = 0;

            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                {
                    area += p[i].X * p[0].Y - p[0].X * p[i].Y;
                    continue;
                }
                area += p[i].X * p[i + 1].Y - p[i + 1].X * p[i].Y;
            }
            return Math.Abs(area / 2.0);
        }

        public static double Perimeter(Point[] p, int n)
        {
            double perimeter = 0;
            double x = 0;
            double y = 0;

            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                {
                    x = p[i].X - p[0].X;
                    y = p[i].Y - p[0].Y;
                    perimeter += Math.Sqrt(x * x + y * y);
                    continue;
                }
                x = p[i].X - p[i + 1].X;
                y = p[i].Y - p[i + 1].Y;
                perimeter += Math.Sqrt(x * x + y * y);
            }

            return perimeter;
        }
    }

    class PerimeterAreaOfPolygon
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number of points: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter point coordinates on a line, separated by a space -> x y");
            Point[] point = new Point[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter point[{0}]: ", i + 1);
                string[] pointCoordinates = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                point[i] = new Point() { X = double.Parse(pointCoordinates[0]), Y = double.Parse(pointCoordinates[1]) };
            }

            double calcPerimeter = Polygon.Perimeter(point, n);
            double calcArea = Polygon.Area(point, n);

            Console.WriteLine("\nperimeter = {0:F2}", calcPerimeter);
            Console.WriteLine("area = {0:F2}", calcArea);
        }
    }
}
