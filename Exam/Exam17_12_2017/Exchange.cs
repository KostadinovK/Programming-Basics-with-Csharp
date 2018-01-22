using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange {
    class Program {
        static void Main(string[] args) {
            double dollars = double.Parse(Console.ReadLine());
            double priceOfBitCoin = double.Parse(Console.ReadLine());
            double satoshiForByte = double.Parse(Console.ReadLine());
            double bitCoinsForTheMoney = dollars / priceOfBitCoin;
            double tax = bitCoinsForTheMoney * (satoshiForByte * 1024) / 100000000;
            double bitCoinsWithtax = bitCoinsForTheMoney - tax;
            double payment = bitCoinsWithtax / 10;
            double result =bitCoinsWithtax - payment;
            double taxInUSD = tax * priceOfBitCoin;
            Console.WriteLine($"Total bitcoins after expenses: {result:f5} BTC");
            Console.WriteLine($"Tax payed: {taxInUSD:f2} USD");
            Console.WriteLine($"Programmer's payment: {payment:f5} BTC");
            
        }
        
    }
}
