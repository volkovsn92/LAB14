using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask_String_Format_
{
    class Parser
    {
        private List<int> intFound = new List<int>();
        private int intCount;

        private int realCount;
        private List<double> realFound = new List<double>();

        private List<string> notNumbers = new List<string>();

        public List<int> IntFound { get { return this.intFound; } set { } }
        public int IntCount { get { return this.intCount; } set { } }

        public List<double> RealFound { get { return this.realFound; } set { } }
        public int RealCount { get { return this.realCount; } set { } }

        public List<string> NotNumbers { get { return this.notNumbers; } set { } }

        public string[] Split(string str)
        {
            string[] strings = str.Split(' ');
            return strings;
        }

        public  void FindInts(string[] arr)
        {
            foreach (var item in arr)
            {
                int result = 0;
                if (int.TryParse(item, out result))
                {
                    intFound.Add(result);
                    intCount++;
                } 
            }
        }

        public void FindReals(string[] arr)
        {
            foreach (var item in arr)
            {
                double result = 0;
                int resultI = 0;
                if ((double.TryParse(item, out result)) ^ (int.TryParse(item, out resultI)))
                {
                    realFound.Add(result);
                    realCount++;
                }
            }
        }

        public void FindNaN(string[] arr)
        {
            foreach (var item in arr)
            {
                double resultD = 0.0;
                int resultI = 0;
                if ((!double.TryParse(item, out resultD)) || (!int.TryParse(item, out resultI)))
                {
                    notNumbers.Add(item);
                }
            }
        }
    }
}
