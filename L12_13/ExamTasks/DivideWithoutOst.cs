using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideWithoutOst {
    class Program {
        static void Main(string[] args) {
            double p1 = 0, p2 = 0, p3 = 0;
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i< n;i++) {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0) {
                    p1++;
                }
                if (num % 3 == 0) {
                    p2++;
                }
                if (num % 4 == 0) {
                    p3++;
                }

            }
            
            Console.WriteLine($"{p1/n*100:f2}%");
            Console.WriteLine($"{p2 / n * 100:f2}%");
            Console.WriteLine($"{p3 / n * 100:f2}%");
        }
    }
}
