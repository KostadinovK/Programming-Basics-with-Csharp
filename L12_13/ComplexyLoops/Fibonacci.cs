using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            int a=1, b=1, c=1;
            for (int i = 1;i<n;i++) {
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine(c);
        }
    }
}
