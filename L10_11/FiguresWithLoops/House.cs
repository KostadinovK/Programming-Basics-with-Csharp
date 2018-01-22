using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House {
    class Program {
        static void Main(string[] args) {
            var n = int.Parse(Console.ReadLine());
            int StarsCount = 1;
            int FirstRows = (n + 1) / 2;
            int SecondRows = n - FirstRows;
            if (n % 2 == 0) StarsCount = 2;
            else StarsCount = 1;

             //First Part
            for (int i = 0;i<FirstRows;i++) {
                for (int j = 0;j<(n-StarsCount)/2;j++) {
                    Console.Write("-");
                }
                for (int j = 0;j<StarsCount;j++) {
                    Console.Write("*");
                }
                for (int j = 0; j < (n - StarsCount) / 2; j++) {
                    Console.Write("-");
                }
                StarsCount = StarsCount + 2;
                Console.WriteLine();
            }
        
            //Second Part
            for (int i = 0;i<SecondRows;i++) {
                for (int j = 0;j<n;j++) {
                    if (j == 0 || j == n - 1) {
                        Console.Write("|");
                    } else {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
           
        }
    }
}
