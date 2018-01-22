using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateCodes {
    class Program {
        static void Main(string[] args) {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int firstD = 0;firstD <= 9;firstD++) {
                for (int secondD = 0;secondD <= 9;secondD++) {
                    for (int thirdD = 0;thirdD <= 9;thirdD++) {
                        for (char firstL = 'a';firstL <= 'z';firstL++) {
                            for (char secondL = 'a';secondL <= 'z';secondL++) {
                                for (int fourthD = 0;fourthD <= 9;fourthD++) {
                                    if ((firstD + secondD + thirdD + fourthD + firstL + secondL == m) && (counter < n)) {
                                        Console.Write($"{firstD}{secondD}{thirdD}{firstL}{secondL}{fourthD} ");
                                        counter++;
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
