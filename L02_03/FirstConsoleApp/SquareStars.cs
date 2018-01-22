using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareStars
{
    class Program
    {
        static void Main(string[] args) {
            var n = int.Parse(Console.ReadLine());
            int i=0;
            for (i=1;i<=n;i++) {
                for (j = 1; j <= n; j++) {
                    if (i == 1 || i == n)
                    {
                        for (j = 1; j <= n; j++)
                        {
                            Console.Write("*");
                        }
                    }
                }
                else {

                }

                for (j=1;j<=i;i++) {

                }
            }
        
        }
    }
}
