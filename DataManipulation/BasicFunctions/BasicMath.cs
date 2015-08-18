using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManipulation.BasicFunctions
{
    public static class BasicMath
    {
        public static int Addition(int firstNumber, int secondNumber)
        {
            var result = firstNumber + secondNumber;
            return result;
        }

        public static int Multiplication(int firstNumber, int secondNumber)
        {
            var result = firstNumber * secondNumber;
            return result;
        }
    }
}
