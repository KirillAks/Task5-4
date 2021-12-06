using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_4
{
    class Program
    {
        // Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. Определить количество нечетных положительных элементов, стоящих на четных местах.
        static void Main(string[] args)
        {
            Console.WriteLine("Массив сформирован справа налево");
            int[] array = new int[20];
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int counterUneven=0;
            for (int i = 0; i < 20; i+=2)
            {
                if (array[i] > 0 && array[i] % 2 != 0)
                    counterUneven++;                    
            }
            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах равно {0}", counterUneven);
            Console.ReadKey();
        }
    }
}
