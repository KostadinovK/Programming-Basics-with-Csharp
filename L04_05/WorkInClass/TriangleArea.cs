using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            
            double area = a * height / 2;
            Console.WriteLine(Math.Round(area,2));
        }
    }
}
