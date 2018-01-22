using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCoin {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int middleRows;
            if (n % 2 == 0) middleRows = n - 1;
            else middleRows = n - 2;
           
            //First Row
            int spaceNum = 2 * n;
            int charsOnMiddleRow = 2 * n + 2 * n + spaceNum / 2 + spaceNum / 2;
            string spaces = new string(' ',spaceNum);
            string c1 = new string('\\',spaceNum/2);
            string c2 = new string('/',spaceNum/2);
            Console.WriteLine($"{spaces}{c1}{c2}{spaces}");
            //Second to Middle Rows
            int minusCount = 1;
            for (int i = 1;i<=n-1;i++) {
                spaceNum = spaceNum - 2;
                minusCount = 6 * i; 
                spaces = new string(' ',spaceNum);
                c1 = new string('\\',spaceNum/2);
                string minuses = new string('-',minusCount);
                c2 = new string('/',spaceNum/2);
                Console.WriteLine($"{spaces}{c1}{minuses}{c2}{spaces}");
            }
            //Middle Rows
            int specialRow;
            if (middleRows == 1) {
                specialRow = 1;
            } else {
                specialRow = (middleRows + 1) / 2;
            }
            string minusesMiddleRows, others;
            for (int i = 1;i<=middleRows;i++) {
                int minusCount2 = n - 1;
                int othersCount = charsOnMiddleRow - 2 - (n - 1) - (n - 1);
                if (i != specialRow) {
                    minusesMiddleRows = new string('-',minusCount2);
                    others = new string('#',othersCount);
                    Console.WriteLine($"|{minusesMiddleRows}{others}{minusesMiddleRows}|");
                } else {
                    minusesMiddleRows = new string('~',minusCount2);
                    int size = othersCount - 6;
                    string othersFirstPart = new string('/',size/2);
                    string othersLastPart = new string('\\',size/2);
                    Console.WriteLine($"|{minusesMiddleRows}{othersFirstPart} ESTD {othersLastPart}{minusesMiddleRows}|");
                }
            }
            //Middle to Last Rows
            int spaceNums = 2;
            minusCount = minusCount + 6;
            for (int i = 1; i <= n - 1; i++) {
                spaceNums = 2 * i;
                minusCount = minusCount - 6; ;
                spaces = new string(' ', spaceNums);
                c1 = new string('\\', spaceNums / 2);
                string minuses = new string('-', minusCount);
                c2 = new string('/', spaceNums / 2);
                Console.WriteLine($"{spaces}{c1}{minuses}{c2}{spaces}");
            }
            //Last Row
            spaceNum = 2 * n;
            charsOnMiddleRow = 2 * n + 2 * n + spaceNum / 2 + spaceNum / 2;
            spaces = new string(' ', spaceNum);
            c1 = new string('\\', spaceNum / 2);
            c2 = new string('/', spaceNum / 2);
            Console.WriteLine($"{spaces}{c1}{c2}{spaces}");

        }
    }
}
