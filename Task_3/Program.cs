using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int cnt_gen = 0;
            int cnt_a = 0;
            int cnt_b = 0;

            if ((c > a) || (c > b))
            {
                cnt_gen = 0;
            }
            else
            {
                while (a > 0)
                {
                    if (a - c < 0)
                    {
                        break;
                    }
                    else
                    {
                        a -= c;
                        cnt_a++;
                    }
                }

                while (b > 0)
                {
                    if (b - c < 0)
                    {
                        break;
                    }
                    else
                    {
                        b -= c;
                        cnt_b++;
                    }
                }
            }
            cnt_gen = cnt_a * cnt_b;
            Console.WriteLine($"Количество квадратов со стороной C в прямоугольнике размерами AхB - {cnt_gen}.");
        }
    }
}
