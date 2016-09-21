using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask_Strings_
{
    class Program
    {
        static void Main(string[] args)
        {
            Source src = new Source();
            string baseString = src.ReadConsole();
            string stringLowerCase = src.ChangeStringToLowerCase(baseString);
            string finalString = src.AddLineBreaksWithDate(stringLowerCase);
            src.Print(finalString);
            Console.ReadLine();
        }
    }
}
