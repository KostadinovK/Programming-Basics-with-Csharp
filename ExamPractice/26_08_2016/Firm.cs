using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm {
    class Program {
        static void Main(string[] args) {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int emergencyPersons = int.Parse(Console.ReadLine());
            int emergencyHours = 2 * emergencyPersons;
            int hours = 8 * days + emergencyHours;


        }
    }
}
