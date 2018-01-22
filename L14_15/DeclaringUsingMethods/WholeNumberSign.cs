using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholeNumberSign {
    class Program {
        static void Main(string[] args) {
            int num = int.Parse(Console.ReadLine());
            Sign(num);
        }
        static void Sign(int number) {
            if (number > 0) Console.WriteLine($"The number {number} is positive.");
            else if (number < 0) Console.WriteLine($"The number {number} is negative.");
            else Console.WriteLine($"The number {number} is zero.");
        }
    }
}
