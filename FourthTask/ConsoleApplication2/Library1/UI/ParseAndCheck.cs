using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1.UI
{
    public class ParseAndCheck
    {
        public bool CheckA(string a)
        {
            double resultDouble = 0.0;
            
            if (double.TryParse(a, out resultDouble)) 
            {
                if (resultDouble == 0.0)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckNumber(string num)
        {
            double resultDouble = 0.0;

            if (double.TryParse(num, out resultDouble))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double ParseDouble(string num)
        {
            return double.Parse(num);
        }

        public bool IsInt(double num)
        {
            string str = num.ToString(); //проверяем на то, есть ли там запятые или точки, чтобы понять, можно ли без вопросов кастануть инт
            if (str.Contains(".") || str.Contains(","))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int CastInt(double num)
        {
            return (int) num; 
        }
    }
}
