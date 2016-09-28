using Library1.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class LinearEquation
    {
        public double A { get; private set; }
        public double B { get; private set; } = 0;
        public string X { get; private set; }

        public LinearEquation(double a, double b)
        {
            A = a;
            B = b;
        }
        public LinearEquation(double a)
        {
            A = a;
        }

        public  void  SolveLE()
        {
            ParseAndCheck pac = new ParseAndCheck();
            double x = Math.Round(((-B) / A), 2);
            int _x = pac.CastInt(x);
            if ((_x < x) || (_x > x))
            {
                X = string.Format("{0:0.##}", x.ToString());
            }
            else
            {
                X = _x.ToString();
            }
        }

        public static double SolveLE(double a, double b)
        {
            double x = (-b)/a;
            return x;    
        }
    }
}
