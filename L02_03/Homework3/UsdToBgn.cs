using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsdToBgn
{
    class Program
    {
        static void Main(string[] args)
        {
            var usd = double.Parse(Console.ReadLine());
            var bgn = usd * 1.79594;
            Console.WriteLine(bgn + " BGN");
        }
    }
}
