using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask_String_Format_
{
    class ConsoleReader
    {
        private List<string> input = new List<string>();
        public List<string> Input { get { return this.input; } set { } }

        public ConsoleReader()
        {
            ReadConsole();
        }

        public void ReadConsole()
        {
            string inputString;
            while (true)
            {
                inputString = Console.ReadLine();
                if (inputString.Equals(""))
                {
                    break;
                }
                else
                {
                    input.Add(inputString);
                }
            }
        }
    }
}
