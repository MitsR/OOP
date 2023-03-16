using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace work_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Результат функцiї f(x)=1/x^(1/3) в iнтервалi 5 i 8 = {Trap(func1, 5, 8)}\n");
            Console.WriteLine($"Результат функцiї f(x)=1/(x^2)^(1/2) в iнтервалi 9 i 13 = {Trap(func2, 9, 13)}\n");
            Console.WriteLine($"Результат функцiї f(x)=cos(x) в iнтервалi 21 i 35 = {Trap(func3, 21, 35)}\n");
            MEvent m = new MEvent();
            m.KeyPress += handler;
            m.Read();
        }
        delegate double Func(double x);
        static double func1(double x) => 1 / Math.Pow(Math.Pow(x,2)+4,1/3.0);
        static double func2(double x) => 1 / Math.Sqrt(Math.Pow(x, 2));
        static double func3(double x) => Math.Cos(x);
        static double Trap(Func F, double a, double b, UInt16 pre = 50)
        {
            if (pre == 0) pre = 1;
            double s = Math.Abs(b - a) / pre;
            double res = (F(a) + F(b)) / 2;
            for (double i = a + s; i < b; i += s) res += F(i);
            return Math.Round(Math.Abs(res * s), 5);
        }
        static void handler(string text) { Console.WriteLine(text); } 
        delegate void MyEvent(string text);
        class MEvent
        {
            static public string name = "услан";
            public event MyEvent KeyPress;
            public void Read()
            {
                Console.Write("Введiть текст ");
                while (true)
                {
                    char symbol = Console.ReadKey(true).KeyChar;
                    Console.Write(symbol);
                    if (symbol == 'Р') 
                    {
                        KeyPress(name);
                        break;
                    } 
                }
            }
        }
    }
}
