using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputEvenNumber {
    class Program {
        static void Main(string[] args) {
            int num;
            while (true) {
                try {
                    Console.Write("Enter even number: ");
                    num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0) {
                        break;
                    } else {
                        Console.WriteLine("The number is not even.");
                    }
                } catch {
                    Console.WriteLine("Invalid number!");
                }
            }
            Console.WriteLine("Even number entered: " + num);
        }
    }
}
