using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond {
    class Program {
        static void Main(string[] args) {
            var n = int.Parse(Console.ReadLine());
            int rows,StarsOnFirstRow = 0;
            if (n % 2 == 0) {
                StarsOnFirstRow = 2;
                rows = n - 1;
            } else {
                StarsOnFirstRow = 1;
                rows = n;
            }
            //Console.WriteLine("rows = "+ rows);
            int OtherSpacesOnRow = n - StarsOnFirstRow;
            //Fist Row
            for (int i = 0;i<OtherSpacesOnRow/2;i++) {
                Console.Write("-");
            }
            for (int i = 0;i<StarsOnFirstRow;i++) {
                Console.Write("*");
            }
            for (int i = 0; i < OtherSpacesOnRow / 2; i++) {
                Console.Write("-");
            }
            Console.WriteLine();
            //Middle
            int SpaceBetweenStars = StarsOnFirstRow;
            int FirstRows = (rows+1-1) / 2;
            int max = (rows - 2 + 1) / 2;
            //Console.WriteLine("FirstRows(without the first) = " + FirstRows);
            int count = 0;
            for (int i = 0;i<max;i++) {
                for (int j = 0;j<(n - (SpaceBetweenStars+2))/2;j++) {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int j = 0; j < SpaceBetweenStars; j++) {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int j = 0; j < (n - SpaceBetweenStars - 2) / 2; j++) {
                    Console.Write("-");
                }

                
                    
                
                SpaceBetweenStars += 2;
                count = SpaceBetweenStars-2;
                if(i != max-1) {
                    Console.WriteLine();
                }
                
                
            }
            Console.WriteLine();
            count = count - 2;
            int OtherRows = rows - FirstRows - 2;
            //Console.WriteLine("OtherRows(without the last) = " + OtherRows);
            for (int i = 0; i <= OtherRows; i++) {
                if (i != OtherRows) {
                    for (int j = 0; j < (n - (count + 2)) / 2; j++) {
                        Console.Write("-");
                    }
                    Console.Write("*");
                    for (int j = 0; j < count; j++) {
                        Console.Write("-");
                    }
                    Console.Write("*");
                    for (int j = 0; j < (n - (count + 2)) / 2; j++) {
                        Console.Write("-");
                    }
                    count -= 2;
                    Console.WriteLine();

                } else {
                    
                    for (int j = 0; j < OtherSpacesOnRow / 2; j++) {
                        Console.Write("-");
                    }
                    for (int j = 0; j < StarsOnFirstRow; j++) {
                        Console.Write("*");
                    }
                    for (int j = 0; j < OtherSpacesOnRow / 2; j++) {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }
                

            }
            Console.WriteLine();
            
        }
    }
}
