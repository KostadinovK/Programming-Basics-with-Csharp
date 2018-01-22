using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test { 

    class Program { 
    
        static void Main(string[] args) {


            /*int i;
            Console.WriteLine("Hello C#");
            for (i=200;i<8000;i=i+100) {
                Console.Beep(i,500);

            }*/
            /*int i, j;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }*/
            //1000 florinta - 7 lewa
            Console.WriteLine("1.Euros");
            Console.WriteLine("2.Dinari");
            Console.WriteLine("3.Florints");
            Console.Write("Choice: ");
            var choice = int.Parse(Console.ReadLine());
            double firstCurrency;
            double secondCurrency=0;
            const double DinarForLev = 113/2;
            const double FlorintForLev = 1000/7;
            Console.Write("First Currency: ");
            firstCurrency = double.Parse(Console.ReadLine());
            switch (choice) {
                case 1: secondCurrency = firstCurrency / 1.955;break;
                case 2: secondCurrency = firstCurrency / DinarForLev;break;
                case 3: secondCurrency = firstCurrency / FlorintForLev;break;
            }

            Console.WriteLine("Leva = " + secondCurrency);
        }
    }
}
