using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From100To200 {
    class Program {
        static void Main(string[] args) {
            var number = int.Parse(Console.ReadLine());
            if (number < 100) {
                Console.WriteLine("Less than 100");
            } else if (number > 200) {
                Console.WriteLine("Greater than 200");
            } else {
                Console.WriteLine("Between 100 and 200");
            }


        }
    }
}
