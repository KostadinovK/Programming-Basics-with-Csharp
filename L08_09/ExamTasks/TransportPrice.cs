using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice {
    class Program {
        static void Main(string[] args) {
            var km = int.Parse(Console.ReadLine());
            var timeOfDay = Console.ReadLine();
            double price = 0;
            if (km < 20) {
                price = 0.70;
                if (timeOfDay == "day") {
                    price = price + 0.79 * km;
                } else if (timeOfDay == "night") {
                    price = price + 0.90 * km;
                } else {
                    Console.WriteLine("Invalid time of day");
                }
            } else if (km >= 100) {
                price = 0.06 * km;
            } else {
                price = 0.09 * km;
            }
            Console.WriteLine("{0:f2}",price);
        }
    }
}
