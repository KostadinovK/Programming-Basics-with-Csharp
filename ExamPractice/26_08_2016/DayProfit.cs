using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayProfit {
    class Program {
        static void Main(string[] args) {
            int workingDays = int.Parse(Console.ReadLine());
            double moneyPerWorkingDay = double.Parse(Console.ReadLine());
            double UsdBgn = double.Parse(Console.ReadLine());

            double monthWage = workingDays * moneyPerWorkingDay;
            double yearWage = monthWage * 12 + monthWage * 2.5;
            yearWage = yearWage - yearWage * 25 / 100;

            double yearWageInBGN = yearWage * UsdBgn;
            double moneyPerDay = yearWageInBGN / 365;
            Console.WriteLine($"{moneyPerDay:f2}");
        }
    }
}
