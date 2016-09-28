using ConsoleApplication1.ConversationWithUser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Service
{
    public class Creator
    {
        public string DirName { get; private set; }
        public void CreateDirectory(string dirName)
        {
            if (!(Directory.Exists(dirName)))
            {
                DirectoryInfo di = new DirectoryInfo(dirName);
                di.Create();
                DirName = di.FullName;
                
            }
            else //TODO
            {
                Reader reader = new Reader();
                Printer.Print(Phrases.DirecotyAlreadyCreated);
                CreateDirectory(reader.ReadLineFromConsole());
            }
        }
    }
}
