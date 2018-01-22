using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToSants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches: ");
            var inches = double.Parse(Console.ReadLine());
            var santi = inches * 2.54;
            Console.WriteLine("Santi: " + santi);
        }
    }
}
