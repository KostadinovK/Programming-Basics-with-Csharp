using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingV2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var fname = Console.ReadLine();
           
            var lname = Console.ReadLine();
            
            var age = int.Parse(Console.ReadLine());
           
            var town = Console.ReadLine();
            Console.WriteLine("Hello " + fname + " " + lname + ", a" + age + "- years old person from " + town + ".");
        }
    }
}
