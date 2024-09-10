using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Calcute : IClcute
    {
        public int sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int minuse(int num1, int num2)
        {
            return num1 - num2;
        }

        public int divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public int multiple(int num1, int num2)
        {
            return num1 * num2;
        }

        public double person(double num1, double num2)
        {
            double divide = num1 / num2;

            double person = divide * 100;
            return person;
        }

        public double tavan(double num1, double num2)
        {
            double tavan = Math.Pow(num1, num2);
            return tavan;
        }

        public double tavan2(double num1)
        {
            double tavan2 = Math.Pow(num1, 2);
            return tavan2;
        }
    }
}
