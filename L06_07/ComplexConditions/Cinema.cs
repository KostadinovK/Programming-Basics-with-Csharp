using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema {
    class Program {
        static void Main(string[] args) {
            var projection = Console.ReadLine();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            int seats = r * c;
            double price = 0;
            if (projection == "Premiere") {
                price = 12;
            } else if (projection == "Normal") {
                price = 7.5;
            } else if (projection == "Discount") {
                price = 5;
            } else {
                Console.WriteLine("Invalid projection");
            }

            double result = seats * price;
            Console.WriteLine("{0:f2}",result);

        }
    }
}
