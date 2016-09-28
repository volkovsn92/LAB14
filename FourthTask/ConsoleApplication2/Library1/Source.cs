using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library1.UI;
using Library1.SimpleLogger;

namespace Library1
{
    public class Source
    {
        public static void Run()
        {
            Logger log = new Logger();
            Printer pr = new Printer(); //вызываем принтер

            pr.Print(Phrases.Greetings); //приветствие и просьба ввести данные

            ConsoleReader cr = new ConsoleReader();
            if (cr.ReadConsoleForMenu()) //если 1 (если белиберда, то цикл будет крутиться пока не введешь адекватное решение)
            {
                pr.Print(Phrases.LE); //Вы выбрали линейное уравнение
                log.WriteToLog(Phrases.LE);
                pr.Print(Phrases.EMemberA); //просим ввести а

                LinearEquation linEq = new LinearEquation(cr.ReadConsoleForA(), cr.ReadConsoleForNum()); //создаем объект уравнения
                linEq.SolveLE(); //решаем
                pr.Print($"{Phrases.Result}\n{Phrases.X1} {linEq.X}"); //выводим результат

                log.WriteToLog($"{Phrases.Result}\n{Phrases.X1} {linEq.X}");

                
            }
            else //если 2
            {
                pr.Print(Phrases.QE); //Вы выбрали квадратное уравнение
                log.WriteToLog(Phrases.QE);

                pr.Print(Phrases.EMemberA); // просим ввести а

                QuadraticEquation qEq = new QuadraticEquation(cr.ReadConsoleForA(), cr.ReadConsoleForNum(), cr.ReadConsoleForNum());

                if (qEq.CheckDiscriminant()) 
                {
                    pr.Print(Phrases.NoSolutions);

                    log.WriteToLog(Phrases.NoSolutions);
                }
                else
                {
                    qEq.SolveQE();
                    pr.Print($"{Phrases.Result}\n{Phrases.X1} {qEq.X1}\n{Phrases.X2} {qEq.X2}");

                    log.WriteToLog($"{Phrases.Result}\n{Phrases.X1} {qEq.X1}\n{Phrases.X2} {qEq.X2}");
                }      
            }
        }
    }
}
