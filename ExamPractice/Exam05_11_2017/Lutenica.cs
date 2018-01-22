using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lutenica {
    class Program {
        static void Main(string[] args) {
            const double lutenicaInJar = 0.535;
            double tomateKG = double.Parse(Console.ReadLine());
            double lutenicaKG = tomateKG / 5;
            int boxesInATruck = int.Parse(Console.ReadLine());
            int jarsInABox = int.Parse(Console.ReadLine());

            double jars = lutenicaKG / lutenicaInJar;
            double boxes = Math.Floor(jars) / boxesInATruck;
            Console.WriteLine($"Total lutenica: {lutenicaKG} kilograms.");

            if (boxes >= boxesInATruck) {
                Console.WriteLine($"{Math.Floor(boxes) - boxesInATruck} boxes left.");
                Console.WriteLine($"{Math.Floor(jars) - Math.Floor(boxes)*jarsInABox} jars left.");

            } else {
                Console.WriteLine($"{boxesInATruck - Math.Floor(boxes)} more boxes need.");
                
                Console.WriteLine($"{Math.Floor(boxes) * jarsInABox - Math.Floor(jars)} more jars need.");
            }
            
            


        }
    }
}
