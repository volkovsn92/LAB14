using ConsoleApplication1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Logic
{
    public class Logic1
    {
        public void DoFirstTask()
        {
            Printer.Print(ConversationWithUser.Phrases.Greetings);
            Creator creator = new Creator();
            Reader reader = new Reader();
            creator.CreateDirectory(reader.ReadLineFromConsole());
            reader.ReadSomeFromFile(HardCodeConsts.FullNameForOriginalFile, HardCodeConsts.QuantityLines);

            Writer writer = new Writer();
            writer.WriteToFile(reader.FileText, creator.DirName, HardCodeConsts.ResultFileName);
                        
        }
    }
}
