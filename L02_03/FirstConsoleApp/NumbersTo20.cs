using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersTo20
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 20; i++) {

                Console.WriteLine(i);
            }
            Console.Write("Enter a: ");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine(a);
        }
    }
}
