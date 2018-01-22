using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumSequence2k_1 {
    class Program {
        static void Main(string[] args) {
            var n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n) {
                Console.WriteLine(i);
                i = i * 2 + 1;
            }


        }
    }
}
