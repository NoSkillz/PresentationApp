using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExamples
{
    class Program
    {
        static void Main()
        {
            int Int;
            float Float;
            double Double;
            decimal Decimal;

            var firstNumber = Console.ReadLine();
            var secondNumber = Console.ReadLine();

            var result = firstNumber + secondNumber;

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
