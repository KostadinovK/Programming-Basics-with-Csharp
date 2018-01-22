using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresStars
{
    class Program
    {
        static void Main(string[] args) {
            int i, j;
            var n = int.Parse(Console.ReadLine());
            for (i=0;i<n;i++) {
                if (i == 0 || i == n - 1)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else {
                    for (j = 0; j < n; j++)
                    {
                        if (j == 0 || j == n - 1) Console.Write("*");
                        else Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                
            }
        }
    }
}
