using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password {
    class Program {
        static void Main(string[] args) {
            var pass = Console.ReadLine();
            string RealPass = "s3cr3t!P@ssw0rd";
            if (pass == RealPass) Console.WriteLine("Welcome");
            else Console.WriteLine("Wrong password!");
        }
    }
}
