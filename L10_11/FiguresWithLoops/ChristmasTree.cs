using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree {
    class Program {
        static void Main(string[] args) {
            var n = int.Parse(Console.ReadLine());
            for (int row = 0; row <= n; row++) {
                var numberOfStars = row;
                var numberOfSpaces = n - numberOfStars;
                //First Part
                for (int i = 0;i<numberOfSpaces;i++) {
                    Console.Write(" ");
                }
                for (int j = 0;j<numberOfStars;j++) {
                    Console.Write("*");
                }
                //Middle
                Console.Write(" | ");

                //Second Part
                for (int j = 0; j < numberOfStars; j++) {
                    Console.Write("*");
                }
                for (int i = 0; i < numberOfSpaces; i++) {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
