using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            double width = Math.Abs(x1 - x2);
            double height = Math.Abs(y1-y2);
            double area = width * height;
            double perimeter = 2 * width + 2 * height;
            Console.WriteLine(area);
            Console.WriteLine(perimeter);

        }
    }
}
