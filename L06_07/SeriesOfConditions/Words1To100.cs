using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words1To100 {
    class Program {
        static void Main(string[] args) {

            var number = int.Parse(Console.ReadLine());
            int firstDigit = 0;
            if (number > 9) firstDigit = number / 10;

        }
    }
}
