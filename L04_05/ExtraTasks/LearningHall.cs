using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHall {
    class Program {
        static void Main(string[] args) {
            const int CoridorHeight = 100;
            const int RowWidth = 120;
            const int PlacesWidth = 70;
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            double widthCm = width * 100;
            double heightCm = height * 100;
            double rows = Math.Floor(widthCm / RowWidth);
            Console.WriteLine("rows = " + rows);
            double PlacesOnRow = Math.Floor((heightCm - CoridorHeight) / PlacesWidth);
            Console.WriteLine("PlacesOnRow = " + PlacesOnRow);
            double places = rows * PlacesOnRow - 3;
            Console.WriteLine(places);    
        }
    }
}
