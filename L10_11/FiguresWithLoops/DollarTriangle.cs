using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarTriangle {
    class Program {
        static void Main(string[] args) {
            var n = int.Parse(Console.ReadLine());
            for (int cols = 0; cols <= n; cols++) {
                for (int rows = 1; rows <= cols; rows++) {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
