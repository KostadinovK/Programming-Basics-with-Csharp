using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum {
    class Program {
        static void Main(string[] args) {
            var n = int.Parse(Console.ReadLine());
            int sum1 = 0,sum2=0;
            for (int i = 0;i<n;i++) {
                var num = int.Parse(Console.ReadLine());
                sum1 = sum1 + num;
                
            }
            for (int i = 0; i < n; i++) {
                var num = int.Parse(Console.ReadLine());
                sum2 = sum2 + num;

            }
            if (sum1 == sum2) {
                Console.WriteLine("Yes, sum = " + sum1);
            } else {
                Console.WriteLine("No, diff = " + Math.Abs(sum1 - sum2));
            }
        }
    }
}
