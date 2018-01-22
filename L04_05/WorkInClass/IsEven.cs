using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isEven
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var num3 = double.Parse(Console.ReadLine());
            bool areEqual = num1 == num2 && num1 == num3 && num2 == num3;
            if (areEqual) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}
