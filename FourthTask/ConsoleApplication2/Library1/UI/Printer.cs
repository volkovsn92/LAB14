using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1.UI
{
    public class Printer
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }
        public void Print(string str1, string str2)
        {
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
        public void Print(int x1, int x2)
        {
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
        public void Print(int x)
        {
            Console.WriteLine(x);
        }
        public void Print(double x)
        {
            Console.WriteLine(x);
        }
        public void Print(double x1, double x2)
        {
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
        public void Print(int x1, double x2)
        {
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
        public void Print(double x1, int x2)
        {
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}
