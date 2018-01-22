using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplySumOfOddAndEvenDigits {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            if (n < 0) {
                n = Math.Abs(n);
            }
            int sumOfEvenDigits = GetSumOfEvenDigits(n);
            int sumOfOddDigits = GetSumOfOddDigits(n);
            int multipleSum = GetMultipleOfEvensAndOdds(sumOfEvenDigits,sumOfOddDigits);
            Console.WriteLine(multipleSum);
        }
        static int GetSumOfEvenDigits(int n) {
            int digit,sum=0;
            while (n >= 1) {
                digit = n % 10;
                if (digit % 2 == 0) {
                    sum += digit;
                }
                n = n / 10;
            }
            return sum;
        }

        static int GetSumOfOddDigits(int n) {
            int digit, sum = 0;
            while (n >= 1) {
                digit = n % 10;
                if (digit % 2 != 0) {
                    sum += digit;
                }
                n = n / 10;
            }
            return sum;
        }

        static int GetMultipleOfEvensAndOdds(int sum1,int sum2) {
            int res = sum1*sum2;

            return res;
        }
    }
}
