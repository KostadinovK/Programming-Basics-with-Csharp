using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOneNumber {
    class Program {
        static void Main(string[] args) {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double res = OnPower(num, power);
            Console.WriteLine(res);
        }
        static double OnPower(double num, int power) {
            double res = Math.Pow(num, power);
            return res;
        }
    }
}
