using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите количество повторений функции:");
                double x = 0;
                int k = int.Parse(Console.ReadLine());
                for (int i = 0; i < k; i++)
                {
                    x += (Math.Sqrt(GetTest(i)) + GetTest(i)) / 2;
                }
                Console.WriteLine("x = ");
                Console.WriteLine(x);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static double GetTest(int k)
        {
            int y = 5;
            for (int i = 0; i < k; i++)
            {
                y += 7;
            }
            return y;
        }
    }
}
