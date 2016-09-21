using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask_Strings_
{
    class Source
    {
        //public string ReadFile(string path)
        //{
        //    if (File.Exists(path))
        //    {
        //        string[] str = File.ReadAllLines(path);
        //        string newStr = str.ToString();
        //        return newStr;
        //    }
        //    else
        //    {
        //        //TODO 
        //        Console.WriteLine("Wrong Path");
        //        return null;
        //    }
        //}

        public string ReadConsole()
        {
            string str = Console.ReadLine();
            return str;
        }

        public string ChangeStringToLowerCase(string str)
        {
            string newStr = str.ToLower();
            return newStr;
        }

        public string AddLineBreaksWithDate(string str)
        {
            str = $"{DateTime.Now.ToString("U")} {str}";
            str = str.Replace(". ", $".\n{DateTime.Now.ToString("U")} ").Replace("! ", $".\n{DateTime.Now.ToString("U")} ").Replace("! ", $".\n{DateTime.Now.ToString("U")} ");
            return str;
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }

    }
}
