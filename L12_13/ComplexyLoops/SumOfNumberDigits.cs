using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumberDigits {
    class Program {
        static void Main(string[] args) {
            var num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num >= 1) {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
