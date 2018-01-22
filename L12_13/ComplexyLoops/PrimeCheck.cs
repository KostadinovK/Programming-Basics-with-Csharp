using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck {
    class Program {
        static void Main(string[] args) {
            var n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (n < 2) {
                isPrime = false;
            } else {
                for (int i = 2;i<=n/2;i++) {
                    if (n % i == 0) {
                        isPrime = false;
                        break;
                    }
                }
            }
            if(isPrime)Console.WriteLine("Prime");
            else Console.WriteLine("Not Prime");

        }
    }
}
