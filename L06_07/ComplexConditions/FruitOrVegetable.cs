using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrVegetable {
    class Program {
        static void Main(string[] args) {
            var product = Console.ReadLine();

            if (product == "banana" || product == "apple" || product == "grapes" || product == "lemon" || product == "cherry" || product == "kiwi") {
                Console.WriteLine("fruit");
            } else if (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot") {
                Console.WriteLine("vegetable");
            } else {
                Console.WriteLine("unknown");
            }

        }
    }
}
