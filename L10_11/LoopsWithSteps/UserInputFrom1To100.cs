using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputFrom1To100 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter a number in the range: ");
            var num = int.Parse(Console.ReadLine());
            while (num < 1 || num > 100){
                Console.WriteLine("Invalid number!");
                Console.Write("Enter a number in the range: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(num);
        }
    }
}
