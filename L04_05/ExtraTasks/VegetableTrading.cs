using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableTrading {
    class Program {
        static void Main(string[] args) {

            var VPriceForKilo = double.Parse(Console.ReadLine());
            var FPriceForKilo = double.Parse(Console.ReadLine());
            var VegetableKilos = int.Parse(Console.ReadLine());
            var FruitKilos = int.Parse(Console.ReadLine());

            double VegetablePrice = VPriceForKilo * VegetableKilos / 1.94;
            double FruitPrice = FPriceForKilo * FruitKilos / 1.94;
            Console.WriteLine(Math.Round(VegetablePrice + FruitPrice,2));
        }
    }
}
