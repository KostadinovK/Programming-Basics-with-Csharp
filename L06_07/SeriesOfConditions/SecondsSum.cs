using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondsSum {
    class Program {
        static void Main(string[] args) {
            var time1 = int.Parse(Console.ReadLine());
            var time2 = int.Parse(Console.ReadLine());
            var time3 = int.Parse(Console.ReadLine());

            var totalSeconds = time1 + time2 + time3;
            var minutes = totalSeconds / 60;
            var otherSeconds = totalSeconds % 60;
            Console.Write(minutes + ":");
            if (otherSeconds < 10) {
                Console.WriteLine("0" + otherSeconds);
            } else {
                Console.WriteLine(otherSeconds);
            }
        }
    }
}
