using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Equation
    {
        public double Left { get; set; }
        public double Right { get; set; }

        public Equation()
        {
            Right = 0;
            Left = 0;
            
        }

        public Equation(double right, double left)
        {
            Right = right;
            Left = left;
            
        }

        public double Add()
        {
            double Ans = Left + Right;
            return Ans;
        }

        public double Subtract()
        {
            double Ans=Left - Right;
            return Ans;
        }
        public double Multiply()
        {
            double Ans = Left * Right;
            return Ans;
        }

        public double LeftToThePower(int power)
        {
            
            double ans = Math.Pow(Left,power);
            return ans;
            
        }

        public double RightToThePower(int power)
        {
            
            double ans = Math.Pow(Right, power);
            return ans;
        }
    }
}
