using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeDesk {
    class Program {
        static void Main(string[] args) {
            const double xrpPrice = 0.22;
            const double btcPrice = 6400;
            const double ethPrice = 250;
            string currency = Console.ReadLine();
            double euros = double.Parse(Console.ReadLine());
            if (euros > 1000) euros = euros + (euros / 10);
            double xrpCoins = euros / xrpPrice;
            double btcCoins = euros / btcPrice;
            double ethCoins = euros / ethPrice;
            if (currency == "XRP") {
                if (xrpCoins > 1000 && xrpCoins < 2500) {
                    xrpCoins = xrpCoins + (xrpCoins * 5 / 100);
                } else if (xrpCoins >= 2500) {
                    xrpCoins = xrpCoins + (xrpCoins / 10);
                }
                if (xrpCoins >= 80) {
                    Console.WriteLine($"Successfully purchased {xrpCoins:f3} {currency}");
                } else {
                    Console.WriteLine("Insufficient funds");
                }
            } else if (currency == "BTC") {
                if (btcCoins > 10) {
                    btcCoins = btcCoins + (btcCoins * 2 / 100);
                }
                if (btcCoins >= 0.001) {
                    Console.WriteLine($"Successfully purchased {btcCoins:f3} {currency}");
                } else {
                    Console.WriteLine("Insufficient funds");
                }
            } else if (currency == "ETH") {
                if (ethCoins >= 0.0099) {
                    Console.WriteLine($"Successfully purchased {ethCoins:f3} {currency}");
                } else {
                    Console.WriteLine("Insufficient funds");
                }
            } else {
                Console.WriteLine($"EUR to {currency} is not supported.");

            }


        }
    }
}
