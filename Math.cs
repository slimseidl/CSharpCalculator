using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Calc
    {
     
        public int addNums(int num1, int num2)
        {
            return num1 + num2;
        }

        public int multiplyNums(int num1, int num2)
        {
            return num1 * num2;
        }

        public int subtractNums(int num1, int num2)
        {
            return (num1 - num2);
        }

        public int divideNums(int num1, int num2)
        {
            return num1 / num2;
        }

        public double avgNums(double num1, double num2)
        {
            return (num1 + num2) / 2;
        }
    }
}
