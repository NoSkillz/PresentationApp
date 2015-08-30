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
            string values = string.Format("Int max: {0}\nInt min: {1}\nDouble max: {2}\nDouble min: {3}\nFloat max: {4}\nFloat min: {5}\nDecimalMax: {6}\nDecimal min: {7}\n",
                int    .MaxValue,
                int    .MinValue,
                double .MaxValue,
                double .MinValue,
                float  .MaxValue,
                float  .MinValue,
                decimal.MaxValue,
                decimal.MinValue);
            Console.Write(values);

            // Be specific
            Console.WriteLine("First number: ");
            var firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Second number: ");
            var secondNumber = int.Parse(Console.ReadLine());

            var result = firstNumber + secondNumber;

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
