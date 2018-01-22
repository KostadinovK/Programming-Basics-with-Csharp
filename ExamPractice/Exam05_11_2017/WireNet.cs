using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireNet {
    class Program {
        static void Main(string[] args) {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double netHeight = double.Parse(Console.ReadLine());
            double priceForOneMeterWire = double.Parse(Console.ReadLine());
            double weightOfOneKilogramWire = double.Parse(Console.ReadLine());

            int wireLenght = 2 * width + 2 * height;
            double wirePrice = wireLenght * priceForOneMeterWire;
            double netArea = wireLenght * netHeight;
            double wireWeight = netArea * weightOfOneKilogramWire;

            Console.WriteLine(wireLenght);
            Console.WriteLine($"{wirePrice:f2}");
            Console.WriteLine($"{wireWeight:f3}");

        }
    }
}
