using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNum {
    class Program {
        static void Main(string[] args) {
            string type = Console.ReadLine();
            if (type == "int") {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int max = GetMax(num1, num2);
                Console.WriteLine(max);
            } else if (type == "char") {
                char num1 = char.Parse(Console.ReadLine());
                char num2 = char.Parse(Console.ReadLine());
                char max = GetMax(num1, num2);
                Console.WriteLine(max);
            } else if (type == "string") {
                string num1 = Console.ReadLine();
                string num2 = Console.ReadLine();
                string max = GetMax(num1, num2);
                Console.WriteLine(max);
            }
        }
        static int GetMax(int num1,int num2) {
            int max;
            if (num1 >= num2) {
                max = num1;
            } else {
                max = num2;

            }
            return max;
        }

        static char GetMax(char c1,char c2) {
            if (c1 >= c2) return c1;
            else return c2;
        }
        static string GetMax(string s1,string s2) {
            if (string.Compare(s1, s2, false) == 0 || string.Compare(s1, s2, false) > 0) {
                return s1;
            } else {
                return s2;
            }
        }


    }
}
