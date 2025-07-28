using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Calc
    {
     
        public void addVals(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public void multiplyNums(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }

        public void subtractNums(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }

        public void divideNums(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
