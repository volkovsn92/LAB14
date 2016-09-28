using Library1.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    class QuadraticEquation
    {
        public double A { get; private set; }
        public double B { get; private set; } = 0;
        public double C { get; private set; } = 0;
        public string X1 { get; private set; }
        public string X2 { get; private set; }
        public double Discr { get; private set; }

        public QuadraticEquation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public QuadraticEquation(double a)
        {
            A = a;
        }

        public bool CheckDiscriminant()
        {
            Discr = (B * B) - (4 * A * C);
            if (Discr < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 

        public void SolveQE()
        {
            ParseAndCheck pac = new ParseAndCheck();
            double x1 = Math.Round((((-B) + (Math.Sqrt((B * B) - (4 * A * C)))) / (2 * A)), 2);
            double x2 = Math.Round((((-B) - (Math.Sqrt((B * B) - (4 * A * C)))) / (2 * A)), 2);
            int _x1 = pac.CastInt(x1);
            int _x2 = pac.CastInt(x2);

            if ((_x1 < x1) || (_x1 > x1))
            {
                X1 = string.Format("{0:0.##}", x1.ToString());
            }
            else
            {
                X1 = _x1.ToString();
            }

            if ((_x2 < x1) || (_x2 > x1))
            {
                X2 = string.Format("{0:0.##}", x2.ToString());
            }
            else
            {
                X2 = _x2.ToString();
            }

        }

    }
}
