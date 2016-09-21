using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask_String_Format_
{
    class Printer
    {
        public void Print(List<int> listInt)
        {
            foreach (var item in listInt)
            {
                string str = item.ToString();
                Console.WriteLine(str.PadLeft(20));
            }
        }

        public void Print(List<double> listDouble)
        {
            foreach (var item in listDouble)
            {
                double rounded = Math.Round(item, 2);
                string str = rounded.ToString();
                Console.WriteLine(str.PadLeft(20));
            }
        }

        public void Print(int num)
        {
            Console.WriteLine(num);
        }

        public void Print(double num)
        {
            string str = num.ToString();
            Console.WriteLine(str.PadLeft(20));
        }
    }
}
