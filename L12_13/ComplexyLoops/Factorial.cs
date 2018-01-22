using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial {
    class Program {
        static void Main(string[] args) {
            var n = int.Parse(Console.ReadLine());
            int res = 1;
            for (int i = 1;i <= n;i++) {
                res = res * i;
            }
            Console.WriteLine(res);
        }
    }
}
