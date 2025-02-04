using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sm = 0;

            for (int i = 1; i <= n; i++)
            {
                sm += ((2 * i) - 1);
                Console.WriteLine(sm);
            }
            Console.ReadKey();
        }
    }
}

