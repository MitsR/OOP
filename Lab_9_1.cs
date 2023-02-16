using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Work_1_2
{
    internal class Program
    {
        // розрахунок висоти
        static double Area(double edge, double area)
        {
            area = 6 * (Math.Pow(edge, 2));
            return area;
        }
        // розрахунок об'єму
        static double Volume(double edge, double volume)
        {
            volume = Math.Pow(edge, 3);
            return volume;
        }
        static void Info(double edge, double area, double volume)
        {
            Console.WriteLine($"Куб з ребром {edge} має площу {area} та об'єм {volume} ");
        }
        static void Main()
        {
            double edge, area=0, volume=0;
            Console.WriteLine("Введіть розмір ребра куба, для подальших розрахунків");
            edge = double.Parse(Console.ReadLine());
            area = Area(edge, area);
            volume = Volume(edge, volume);
            Info(edge, area, volume);
            Console.WriteLine("Виконання програми завершено");
        }
    }
}

