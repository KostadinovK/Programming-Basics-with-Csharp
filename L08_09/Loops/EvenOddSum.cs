using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddSum {
    class Program {
        static void Main(string[] args) {
            var n = int.Parse(Console.ReadLine());
            int OddSum = 0;
            int EvenSum = 0;
            for (int i = 0;i<n;i++) {
                var num = int.Parse(Console.ReadLine());
                if (i % 2 == 0) {
                    EvenSum += num;
                } else {
                    OddSum += num;
                }
            }
            if (EvenSum == OddSum) {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + OddSum);
            } else {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(EvenSum - OddSum));
            }

        }
    }
}
