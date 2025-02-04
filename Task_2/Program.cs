using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int cnt_positive = 0;
            int cnt_negative = 0;
            
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    cnt_positive++;
                }
                else if (n < 0)
                {
                    cnt_negative++;
                }
            } while (n != 0);

            if (cnt_positive > cnt_negative)
            {
                Console.WriteLine("Количество положительных чисел больше.");
            }
            else if (cnt_negative > cnt_positive)
            {
                Console.WriteLine("Количество отрицательных чисел больше.");
            }
            else
            {
                Console.WriteLine("Количество положительных и отрицательных чисел совпадает");
            }
            Console.ReadKey();
        }
    }
}
