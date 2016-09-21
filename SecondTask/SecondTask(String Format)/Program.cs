using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask_String_Format_
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleReader cr = new ConsoleReader();
            Parser p = new Parser();
            foreach (var item in cr.Input)
            {
                string[] splittedString = p.Split(item);
                p.FindInts(splittedString);
                p.FindReals(splittedString);
                p.FindNaN(splittedString);
            }
            Printer printer = new Printer();
            printer.Print(p.IntCount);
            printer.Print(p.RealCount);

            printer.Print(p.IntFound);
            Arithmetics ar = new Arithmetics();
            printer.Print(ar.GetAverage(p.IntFound));

            printer.Print(p.RealFound);
            printer.Print(ar.GetAverage(p.RealFound));
            Console.ReadLine();
        }
    }
}
