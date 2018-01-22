using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore {
    class Program {
        static void Main(string[] args) {
            var score = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (score <= 100) {
                bonus = bonus + 5;
            } else if (score > 100 && score <= 1000) {
                bonus = score / 5.0;
            } else {
                bonus = score / 10.0;
            }

            if (score % 2 == 0) {
                bonus += 1;
            } else if (score % 10 == 5 ) {
                bonus = bonus + 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(bonus + score);
        }
    }
}
