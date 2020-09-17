using System;
using System.Collections.Generic;

namespace Fibonacchhi_ListImplemenation
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Convert.ToInt32(Console.ReadLine());
            var array = new List<long>();
            for (int i = 0; i <= size; i++)
            {
                if (i <= 1)
                {
                    array.Add(i);
                }
                else
                {
                    array.Add(array[i - 1] + array[i - 2]);
                }
            }
            foreach (int i in array)
            {
                Console.Write(i);
                Console.Write(" ");
            }
        }
    }
}
