using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyCatTom {
    class Program {
        static void Main(string[] args) {
            const int MaximalPlayTime = 30000;
            var holidays = int.Parse(Console.ReadLine());
            int workingDays = 365 - holidays;
            int workingPlayTime = workingDays * 63;
            int holidayPlayTime = holidays * 127;
            int PlayTime = workingPlayTime + holidayPlayTime;
            int difference = Math.Abs(MaximalPlayTime - PlayTime);
            int differenceHours = difference / 60;
            int differenceMinutes = difference % 60;

            if (PlayTime <= MaximalPlayTime) {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine(differenceHours + " hours and " + differenceMinutes + " minutes less for play");
            } else {
                Console.WriteLine("Tom will run away");
                Console.WriteLine(differenceHours + " hours and " + differenceMinutes + " minutes more for play");
            }
        }
    }
}
