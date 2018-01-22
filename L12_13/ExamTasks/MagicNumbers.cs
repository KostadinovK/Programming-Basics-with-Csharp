using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            for (int firstD = 1; firstD <= 9; firstD++) {
                for (int secondD = 1; secondD <= 9; secondD++) {
                    for (int thirdD = 1; thirdD <= 9; thirdD++) {
                        for (int fourthD = 1; fourthD <= 9; fourthD++) {
                            for (int fiveD = 1; fiveD <= 9; fiveD++) {
                                for (int sixthD = 1; sixthD <= 9; sixthD++) {
                                    if (firstD*secondD*thirdD*fourthD*fiveD*sixthD == n) {
                                        Console.Write($"{firstD}{secondD}{thirdD}{fourthD}{fiveD}{sixthD} ");
                                    }

                                }

                            }
                        }

                    }

                }

            }
            Console.WriteLine();
        }
    }
}
