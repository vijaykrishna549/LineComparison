using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x1 and y1 coordinates: ");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 and y2 coordinates: ");
            var x2 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());

            var finalResult = Distance(x1, x2, y1, y2);

            Console.WriteLine("Distance between coordinates {0},{1} and {2},{3} is {4:F}", x1, y1, x2, y2, finalResult);
            Console.ReadKey();
        }

        private static double Distance(double x1, double x2, double y1, double y2)
        {
            var point1 = Math.Pow((x2 - x1), 2);
            var point2 = Math.Pow((y2 - y1), 2);
            var Length = Math.Sqrt(point1 + point2);
            Console.WriteLine("Return value (Equals) = " + point1.Equals(point2));
            Console.WriteLine("Return value (comparison) = " + point1.CompareTo(point2));

            return Length;
            //Console.ReadKey();
        }
    }
}