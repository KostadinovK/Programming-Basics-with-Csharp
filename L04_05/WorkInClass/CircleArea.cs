using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());
            double area = radius * radius * Math.PI;
            double perimeter = radius * Math.PI * 2;
            Console.WriteLine("Area = " + Math.Round(area,2));
            Console.WriteLine("Perimeter = " + Math.Round(perimeter,2));

        }
    }
}
