using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Service
{
    public class Reader
    {
        public static int ConsoleReaderCount { get; private set; }
        public List<string> ConsoleText { get; private set; } = new List<string>();
        public List<string> FileText { get; private set; }
        
        public string ReadLineFromConsole()
        {
            string consoleString = Console.ReadLine();
            ConsoleText.Add(consoleString);
            return consoleString;
        }

        public List<string> ReadSomeFromFile(string path, int quantityLines)
        {
            if (File.Exists(path))
            {
                //StreamReader reader = new StreamReader(path);
                string[] fileStrings = File.ReadAllLines(path);
                FileText = fileStrings.Take(20).ToList();
                return FileText;

            }
            else
            {
                //Printer.Print();
                return null;
            }
        }
    }
}
