using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square10X10 {
    class Program {
        static void Main(string[] args) {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0;i < n;i++) {
                var current = new string('*',n);
                Console.WriteLine(current);
            }

        }
    }
}
