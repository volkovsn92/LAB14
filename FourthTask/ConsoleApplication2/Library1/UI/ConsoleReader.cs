using Library1.SimpleLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1.UI
{
    class ConsoleReader
    {
        public  string ReadConsole()
        {
            return Console.ReadLine();
        }

        public bool ReadConsoleForMenu()
        {
            string input = ReadConsole();
            if (input.Equals("1"))
            {
                return true;
            }
            else if (input.Equals("2"))
            {
                return false;
            }
            else
            {
                Printer pr = new Printer();
                pr.Print(Phrases.WrongType);
                return ReadConsoleForMenu();
            }
        }

        public  double ReadConsoleForA() //метод для ввода адекватного а
        {
            Logger log = new Logger();
            string input = ReadConsole();
            log.WriteToLog(input);

            double a = 0.0;
            ParseAndCheck pac = new ParseAndCheck();
            if (pac.CheckA(input))
            {
                return a = pac.ParseDouble(input);
            }
            else
            {
                Printer pr = new Printer();
                pr.Print(Phrases.EWrongA);
                return ReadConsoleForA();
            }
        }

        public  double ReadConsoleForNum() //метод для ввода адекватных B и C
        {
            Printer pr = new Printer();
            pr.Print(Phrases.EMemberNum);
            string input = ReadConsole();

            Logger log = new Logger();
            log.WriteToLog(input);

            double num = 0.0;
            ParseAndCheck pac = new ParseAndCheck();
            if (pac.CheckNumber(input))
            {
                return num = pac.ParseDouble(input);
            }
            else
            {
                pr.Print(Phrases.EWrongNum);
                return ReadConsoleForNum();
            }
        }
    }
}
