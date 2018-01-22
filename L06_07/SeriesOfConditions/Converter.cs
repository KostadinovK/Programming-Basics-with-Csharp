using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter {
    class Program {
        static void Main(string[] args) {
            var inputNumber = double.Parse(Console.ReadLine());
            var inputMetric = Console.ReadLine();
            var outputMetric = Console.ReadLine();
            double middleValue = 0;
            double outputValue = 1;
            if (inputMetric == "mm") {
                middleValue = inputNumber / 1000;
            } else if (inputMetric == "cm") {
                middleValue = inputNumber / 100;
            } else if (inputMetric == "m") {
                middleValue = inputNumber;
            } else if (inputMetric == "mi") {
                middleValue = inputNumber / 0.000621371192;
            } else if (inputMetric == "in") {
                middleValue = inputNumber / 39.3700787;
            } else if (inputMetric == "ft") {
                middleValue = inputNumber / 3.2808399;
            } else if (inputMetric == "km") {
                middleValue = inputNumber / 0.001;
            } else if (inputMetric == "yd") {
                middleValue = inputNumber / 1.0936133;
            }

            if (outputMetric == "mm") {
                outputValue = middleValue * 1000;
            } else if (outputMetric == "cm") {
                outputValue = middleValue * 100;
            } else if (outputMetric== "m") {
                outputValue = middleValue;
            } else if (outputMetric == "mi") {
                outputValue = middleValue * 0.000621371192;
            } else if (outputMetric == "in") {
                outputValue = middleValue * 39.3700787;
            } else if (outputMetric == "ft") {
                outputValue = middleValue * 3.2808399;
            } else if (outputMetric == "km") {
                outputValue = middleValue * 0.001;
            } else if (outputMetric == "yd") {
                outputValue = middleValue * 1.0936133;
            }
            Console.WriteLine(outputValue + " " + outputMetric);
        }
    }
}
