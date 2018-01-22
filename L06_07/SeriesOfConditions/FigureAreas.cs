using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreas {
    class Program {
        static void Main(string[] args) {
            double area = 0;
            double a = 0;
            var figure = Console.ReadLine();
            if (figure == "square") {
                a = double.Parse(Console.ReadLine());
                area = a * a;
            } else if (figure == "rectangle") {
                a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                area = a * b;
            } else if (figure == "circle") {
                a = double.Parse(Console.ReadLine());
                area = Math.PI * a * a;
            } else if (figure == "triangle") {
                a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                area = (a * h) / 2;
            } else {
                Console.WriteLine("Invalid figure");
            }
            Console.WriteLine(Math.Round(area,3));
        }
    }
}
