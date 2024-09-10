using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal interface IClcute
    {
        int sum(int num1 , int num2);

        int minuse(int num1, int num2);

        int divide(int num1, int num2);

        int multiple(int num1, int num2);

        double person(double num1, double num2);

        double tavan(double num1, double num2);
        double tavan2(double num1);
    }
}
