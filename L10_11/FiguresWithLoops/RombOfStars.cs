using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RombOfStars {
    class Program {
        static void Main(string[] args) {
            var n = int.Parse(Console.ReadLine());
            for (int row = 1;row <= n;row++) {
                var numberOfStartSpaces = n - row;
                for (int j = 0;j<numberOfStartSpaces;j++) {
                    Console.Write(" ");
                }
                for (int i = 0;i<row;i++) {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int row = n-1; row >= 0; row--) {
                var numberOfStartSpaces = n - row;
                for (int j = 0; j < numberOfStartSpaces; j++) {
                    Console.Write(" ");
                }
                for (int i = 0; i < row; i++) {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}
