using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame {
    class Program {
        static void Main(string[] args) {
            /* My solution
             * var n = int.Parse(Console.ReadLine());
            for (int col = 0;col < n;col++) {
                for (int row = 0; row < n; row++) {
                    if ((col == 0 || col == n - 1) && (row == 0 || row == n - 1)) {
                        Console.Write("+ ");
                    } else if ((col != 0 && col != n - 1) && (row == 0 || row == n - 1)) {
                        Console.Write("| ");
                    } else {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }*/
            var n = int.Parse(Console.ReadLine());
            string fill = " ";
            for (int  i = 0;i<n-2;i++) {
                fill += "- ";
            }
            //First row
            Console.WriteLine($"+{fill}+");
            //Middle
            for (int i = 0;i< n-2;i++) {
                Console.WriteLine($"|{fill}|");
            }
            //Last row
            Console.WriteLine($"+{fill}+");
        }
    }
}
