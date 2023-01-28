using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задача
//Массивы состоят из двух элементов. Каждый из 
//массивов умеет находить максимальное значение.Создать массив массивов 
//и найти сумму их максимальных значений.

namespace ArraysClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массив a");
            IntArray intArray = new IntArray(4, 6);
            intArray.printArray();
            Console.WriteLine("Max = " + intArray.maxArray());

            Console.WriteLine();

            Console.WriteLine("Введите массив b");
            DoubleArray doubleArray = new DoubleArray(5.1, 7.6);
            doubleArray.printArray();
            Console.WriteLine("Max = " + doubleArray.maxArray());

            Console.WriteLine();

            Console.WriteLine("Массив массивов");
            MainArray[] mainArray = { new IntArray(4, 4), new IntArray(3, 11), new DoubleArray(2.11, 5.9) };

            double sum = 0;
            for (int i = 0; i < 3; i++)
            {
                mainArray[i].printArray();
                Console.WriteLine("Max = " + mainArray[i].maxArray());
                Console.WriteLine();
                sum += mainArray[i].maxArray();
            }

            Console.WriteLine("Сумма их максимальных значений " + sum);

            Console.ReadKey();
        }
    }
}
