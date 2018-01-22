using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DumbPassGenerator {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            string all = "";
            for (int firstDigit = 1; firstDigit < n; firstDigit++) {
                for (int secondDigit = 1;secondDigit < n;secondDigit++) {
                    for (char firstLetter = 'a'; firstLetter < 'a' + l; firstLetter++) {
                        for (char secondLetter = 'a'; secondLetter < 'a' + l; secondLetter++) {
                            for (int lastDigit = Math.Max(firstDigit,secondDigit)+1; lastDigit <= n;lastDigit++) {
                                
                                all += $"{firstDigit}{secondDigit}{firstLetter}{secondLetter}{lastDigit} ";
                            }
                        }

                    }
                }
                
            }
            Console.WriteLine(all);
        }
    }
}
