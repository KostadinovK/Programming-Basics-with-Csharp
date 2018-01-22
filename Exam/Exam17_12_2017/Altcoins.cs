using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02Altcoins {
    class Program {
        static void Main(string[] args) {
            double boughtedBitCoins = double.Parse(Console.ReadLine());
            double startingPriceForBitCoins = double.Parse(Console.ReadLine());
            double afterTimePriceForBitCoins = double.Parse(Console.ReadLine());
            double eteriumWanted = double.Parse(Console.ReadLine());
            double neoWanted = double.Parse(Console.ReadLine());

            double profitFromSelling = boughtedBitCoins * afterTimePriceForBitCoins - boughtedBitCoins * startingPriceForBitCoins;
            double eteriumPrice = afterTimePriceForBitCoins * 7.5 / 100;
            double neoPrice = eteriumPrice * 40 / 100;
            double priceInvestitions = eteriumWanted * eteriumPrice + neoWanted * neoPrice;
            if (profitFromSelling >= priceInvestitions) {
                Console.WriteLine($"Stefcho bought {eteriumWanted:f4} Ethereum at a price of {eteriumPrice:f4}");
                Console.WriteLine($"Stefcho bought {neoWanted:f4} Neo at a price of {neoPrice:f4}");
                Console.WriteLine($"Stefcho has {(profitFromSelling - priceInvestitions):f2} profits left for spend.");
            } else {
                Console.WriteLine("Stefcho does not have enough money to make this investment.");
                Console.WriteLine($"He needs {(priceInvestitions - profitFromSelling):f2} more in profits.");
            }

        }
    }
}