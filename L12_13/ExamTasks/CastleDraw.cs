using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleDraw {
    class Program {
        static void Main(string[] args) {
            var n = int.Parse(Console.ReadLine());
            int height = n;
            int width = n * 2;
            int hutsSize = n / 2;
            string huts = new string('^',hutsSize);
            int roofSize = width - 4 - hutsSize*2;
            string roof = new string('_',roofSize);
            Console.WriteLine($"/{huts}\\{roof}/{huts}\\");

            int sizeOfBodyOfFort = height - 3;
            string fillSpaces = new string(' ', width - 2);
            for (int i = 0; i< sizeOfBodyOfFort;i++) {
                Console.WriteLine($"|{fillSpaces}|");
            }
            // last line
            string spaces = new string(' ',(width-2-roofSize)/2);
            Console.WriteLine($"|{spaces}{roof}{spaces}|");

            //last last line 
            string last = new string('_',hutsSize);
            string lastSpaces = new string(' ',roofSize);
            Console.WriteLine($"\\{last}/{lastSpaces}\\{last}/");

        }
    }
}
