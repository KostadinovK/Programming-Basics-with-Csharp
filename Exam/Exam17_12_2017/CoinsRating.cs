using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinsRating {
    class Program {
        static void Main(string[] args) {
            const double dogePrice = 0.07;
            const double iotaPrice = 1.44;
            const double neoPrice = 28.50;
            const double estdPrice = 25.0;
            int n = int.Parse(Console.ReadLine());
            double dogeAmount = 0, iotaAmount = 0, neoAmount = 0, estdAmount = 0;
            int dogePeoples = 0, iotaPeoples = 0, neoPeoples = 0, estdPeoples = 0;
            for (int i = 0; i < n; i++) {
                string currency = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                if (currency == "DOGE") {
                    dogeAmount += amount;
                    dogePeoples++;
                } else if (currency == "IOTA") {
                    iotaAmount += amount;
                    iotaPeoples++;
                } else if (currency == "NEO") {
                    neoAmount += amount;
                    neoPeoples++;
                } else if (currency == "ESTD") {
                    estdAmount += amount;
                    estdPeoples++;
                }
            }
            double totalPrice = dogeAmount * dogePrice + iotaAmount * iotaPrice + neoAmount * neoPrice + estdAmount * estdPrice;
            Console.WriteLine($"Total votes = {n}, Money in market = {totalPrice:f2} EUR");
            Console.WriteLine($"DOGE's contribution: {((dogeAmount*dogePrice/totalPrice)*100):f2}%; People who use DOGE: {dogePeoples}");
            Console.WriteLine($"IOTA's contribution: {((iotaAmount * iotaPrice / totalPrice) * 100):f2}%; People who use IOTA: {iotaPeoples}");
            Console.WriteLine($"NEO's contribution: {((neoAmount * neoPrice / totalPrice) * 100):f2}%; People who use NEO: {neoPeoples}");
            Console.WriteLine($"ESTD's contribution: {((estdAmount * estdPrice / totalPrice) * 100):f2}%; People who use ESTD: {estdPeoples}");

        }
    }
}
