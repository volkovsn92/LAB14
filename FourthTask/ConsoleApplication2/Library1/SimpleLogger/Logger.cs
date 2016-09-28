using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1.SimpleLogger
{
    public class Logger
    {
        public void WriteToLog (string str)
        {
            StreamWriter sr = File.AppendText("Logger.txt");
            sr.WriteLine(str);
            sr.Close();
        }
    }
}
