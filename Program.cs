using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    class Program
    {
        static PointList points = new PointList();
        static void Main(string[] args)
        {
            points.Changed += delegate (object sender, PointListChangedEventArgs e)
            {
                Console.WriteLine($"Change happened: {e.Operation}");
            };

            points.Add(new Point(-4, -7));
            points.Add(new Point(0, 0));
            points.Add(new Point(1, 2));
            points.Add(new Point(-4, 5));
            points.Insert(2, new Point(3, 1));
            points.Add(new Point(7, -2));
            points[0] = new Point(2, 1);
            points.RemoveAt(2);

            Console.WriteLine();

            if (points.Any(points => points.X == 0 && points.Y == 0))
            {
                Console.WriteLine("There is a point at the origin in this set");
                    };

            Console.WriteLine();
            Console.WriteLine("Points from this set in Quadrant I:");
            foreach (Point p in points.Where(points => points.X > 0 && points.Y>0))
            {
                Console.WriteLine(p);
            }
            if (points.All(points => points.X < 20)) {Console.WriteLine("All points have X less than 20");
                    };
           

            Console.WriteLine("Press <ENTER> to exit...");
            Console.ReadLine();

        }
    }
}
