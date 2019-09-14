using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату точки А на числовой прямой");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату точки В на числовой прямой");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату точки С на числовой прямой");
            double C = double.Parse(Console.ReadLine());

            double AC = Math.Abs(C - A);
            double BC = Math.Abs(B - C);
            double Sum = AC + BC;

            Console.Write("Длина отрезка АС:");
            Console.WriteLine("{0:0.###}", AC);
            Console.Write("Длина отрезка BC:");
            Console.WriteLine("{0:0.###}", BC);
            Console.Write("Сумма длин отрезков АС и ВС:");
            Console.WriteLine("{0:0.###}", Sum);
            Console.ReadLine();
        }
    }
}