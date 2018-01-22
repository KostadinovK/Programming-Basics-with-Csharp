using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidOfNums {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int row = 1;;row++) {
                for (int col = 1;col <= n;col++) {
                    Console.Write(num + " ");
                    if (col == row) {
                        Console.WriteLine("col == row");
                        Console.WriteLine();
                    }
                    
                    num++;
                    if (num > n) return;
                }
            }

        }
    }
}
