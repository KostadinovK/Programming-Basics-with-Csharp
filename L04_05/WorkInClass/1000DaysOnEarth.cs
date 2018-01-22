using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysOnEarth {
    class Program {
        static void Main(string[] args) {
            var date = Console.ReadLine();
            string format = "dd-MM-yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;

            DateTime dateAfter1000Days = DateTime.ParseExact(date,format,provider);
            dateAfter1000Days = dateAfter1000Days.AddDays(999);
            Console.WriteLine(dateAfter1000Days.ToString(format));
        }
    }
}
