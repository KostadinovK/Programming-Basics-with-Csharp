using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int rows = 2 * (n - 2) + 1;
            int cols = 2 * n - 1;
            int specialRow = (rows + 1) / 2;
            int sizeOfSpecialSymbols = (cols - 3) / 2;
            string SpecialSymbols;
            for (int row = 1; row <= rows; row++) { 
                if (row % 2 == 0 && row != specialRow && row < specialRow) {
                    SpecialSymbols = new string('-', sizeOfSpecialSymbols);
                    Console.WriteLine($"{SpecialSymbols}\\ /{SpecialSymbols}");
                } else if (row % 2 != 0 && row != specialRow && row < specialRow) {
                    SpecialSymbols = new string('*', sizeOfSpecialSymbols);
                    Console.WriteLine($"{SpecialSymbols}\\ /{SpecialSymbols}");
                }
                if (row == specialRow) {
                    string spaces = new string(' ', (cols - 1) / 2);
                    Console.WriteLine($"{spaces}@{spaces}");
                }
                if (row % 2 == 0 && row != specialRow && row > specialRow) {
                    SpecialSymbols = new string('-', sizeOfSpecialSymbols);
                    Console.WriteLine($"{SpecialSymbols}/ \\{SpecialSymbols}");
                } else if (row % 2 != 0 && row != specialRow && row > specialRow) {
                    SpecialSymbols = new string('*', sizeOfSpecialSymbols);
                    Console.WriteLine($"{SpecialSymbols}/ \\{SpecialSymbols}");
                }
            }
        }
    }
}
