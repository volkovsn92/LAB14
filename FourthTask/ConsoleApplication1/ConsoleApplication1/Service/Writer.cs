using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Service
{
    public class Writer
    {
        public void WriteToFile(List<string> whatToWrite, string dirPath, string fileName)
        {
            StreamWriter writer = File.CreateText($@"{dirPath}\{fileName}");
            foreach (var item in whatToWrite)
            {
                writer.WriteLine(item);
            }
            writer.Close();
        }
    }
}
