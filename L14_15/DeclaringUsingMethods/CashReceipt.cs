using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashReceipt {
    class Program {
        static void Main(string[] args) {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
        static void PrintHeader() {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("----------------------------");
        }
        static void PrintBody() {
            Console.WriteLine("Charged to______________________");
            Console.WriteLine("Received by_____________________");

        }
        static void PrintFooter() {
            Console.WriteLine("------------------------------");
            Console.WriteLine("c Softuni");
            Console.WriteLine();

        }
    }
}
