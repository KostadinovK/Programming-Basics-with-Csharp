using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeIn15minutes {
    class Program {
        static void Main(string[] args) {
            var hours=0;
            var minutes = 0;
            do {
                hours = int.Parse(Console.ReadLine());
            } while (hours < 0 || hours > 23);
            do {
                minutes = int.Parse(Console.ReadLine());
            } while (minutes < 0 || minutes > 59);

            if (minutes + 15 > 59) {
                if (hours == 23) {
                    hours = 0;
                } else {
                    hours = hours + 1;
                }
                minutes = (minutes + 15) - 60;
            } else {
                minutes = minutes + 15;
            }
            if (minutes < 10) Console.WriteLine(hours + ":0" + minutes);
            else Console.WriteLine(hours + ":" + minutes);
        
            

        }
    }
}
