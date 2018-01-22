using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea {
    class Program {
        static void Main(string[] args) {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = getArea(a,h);
            Console.WriteLine(area);
        }

        static double getArea(double a, double h) {
            double area = a*h/2;

            return area;
        }
    }
}
