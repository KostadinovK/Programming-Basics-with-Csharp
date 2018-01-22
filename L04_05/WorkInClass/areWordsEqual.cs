using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areWordsEqual {
    class Program {
        static void Main(string[] args) {

            var word1 = Console.ReadLine();
            var word2 = Console.ReadLine();

            if (word1.ToLower() == word2.ToLower()) {
                Console.WriteLine("yes");
            } else {
                Console.WriteLine("no");
            }
        }
    }
}
