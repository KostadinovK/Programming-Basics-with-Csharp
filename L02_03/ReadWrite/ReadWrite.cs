using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + name);
            Console.WriteLine(age+10);*/
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();

            Console.WriteLine("Hi, " + name + "! You are from " + town + " ,ages: " + age);
            Console.WriteLine($"Hi {name}, you are from {town}, ages - {age}");


        }
    }
}
