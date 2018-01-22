﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillRectangle {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            for (int i = 0;i<n;i++) {
                PrintMiddleRow(n);
            }
            PrintHeaderRow(n);

        }
        static void PrintHeaderRow(int n) {
            Console.WriteLine(new string('-',2*n));
        }
        static void PrintMiddleRow(int n) {
            Console.Write("-");
            for (int i = 1;i<n;i++) {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}
