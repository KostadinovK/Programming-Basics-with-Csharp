using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes {
    class Program {
        static void Main(string[] args) {
            var v = int.Parse(Console.ReadLine());
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            double p1ForHours = p1 * hours;
            double p2ForHours = p2 * hours;
            double sumOfPipes = p1ForHours + p2ForHours;
            double percent = Math.Floor(sumOfPipes / v * 100);
            double percentP1 = Math.Floor(p1ForHours / sumOfPipes * 100);
            double percentP2 = Math.Floor(p2ForHours / sumOfPipes * 100);
            if (sumOfPipes > v) {
                Console.WriteLine("For " + hours + " hours the pool overflows with " + (sumOfPipes - v) + " liters.");
            } else {
                Console.WriteLine("The pool is " + percent + "% full. Pipe 1: " + percentP1 + "%. Pipe 2: " + percentP2 + "%.");
            }
        }
    }
}
