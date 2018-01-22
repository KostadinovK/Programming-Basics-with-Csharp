using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersOf2 {
    class Program {
        static void Main(string[] args) {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(1);
            for (int i = 1;i<=n;i++) {
                Console.WriteLine(Math.Pow(2,i));
            }
        }
    }
}
