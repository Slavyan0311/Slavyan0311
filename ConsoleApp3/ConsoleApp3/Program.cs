using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static double segment1(double x)
        {
            double y1;
            y1 = -0.5 * x - 3;
            return y1;
        }

        static double segment2(double x, double R)
        {
            double y2;

            y2 = Math.Sqrt(R * R - x * x);
            return -y2;
        }
        static string seg(double x)
        {
            string n = ($"Функция не определена при x={x}");
            return n;
        }

        static double segment3(double x, double R)
        {
            double a = 6;
            double b = 0;
            double y3;
            y3 = Math.Sqrt(R * R - (x - a) * (x - a)) - b;
            return y3;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите радиус R: ");
            double R = double.Parse(Console.ReadLine());
            Console.Write("Введите значение аргумента x: ");
            double x = double.Parse(Console.ReadLine());

            if (x > 6)
            {
                Console.WriteLine($" Функция не определена при х от {x} до  + бесконечности");
            }
            for (x = x; x <= 6.0001; x += 0.2)
            {
                if (x < -10 || x > 6.0001)
                {
                    Console.WriteLine($"Функция не определена при x={x}");
                }
                else if (x < 0)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x));
                }
                else if (x < 3 && R == 3)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment2(x, R));
                }
                else if (x < 3 && (R < 3 || R > 3))
                {
                    Console.WriteLine(seg(x));
                }
                else if (x <= 6.0001 && R == 3)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment3(x, R));
                }
                else Console.WriteLine(seg(x));

            }
        }
    }
}