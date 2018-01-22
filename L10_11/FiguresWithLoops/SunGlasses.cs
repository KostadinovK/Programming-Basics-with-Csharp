using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunGlasses {
    class Program {
        static void Main(string[] args) {
            var n = int.Parse(Console.ReadLine());

            //First Row
            for (int i = 0; i < n * 2; i++) {
                Console.Write("*");
            }
            for (int i = 0; i < n; i++) {
                Console.Write(" ");
            }
            for (int i = 0; i < n * 2; i++) {
                Console.Write("*");
            }
            Console.WriteLine();
            //Middle
            var specialRow = (n - 2 - 1) / 2;
            for (int row = 0; row < n - 2; row++) {
                for (int i = 0; i < n * 2; i++) {
                    if (i == 0 || i == n * 2 - 1) {
                        Console.Write("*");
                    } else {
                        Console.Write("/");
                    }
                }
                if (row == specialRow) {
                    for (int j = 0; j < n; j++) {
                        Console.Write("|");
                    }
                } else {
                    for (int j = 0; j < n; j++) {
                        Console.Write(" ");
                    }
                    
                 
                }
                for (int i = 0; i < n * 2; i++) {
                    if (i == 0 || i == n * 2 - 1) {
                        Console.Write("*");
                    } else {
                        Console.Write("/");
                    }
                }
                Console.WriteLine();

                
            }
            for (int i = 0; i < n * 2; i++) {
                Console.Write("*");
            }
            for (int i = 0; i < n; i++) {
                Console.Write(" ");
            }
            for (int i = 0; i < n * 2; i++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
