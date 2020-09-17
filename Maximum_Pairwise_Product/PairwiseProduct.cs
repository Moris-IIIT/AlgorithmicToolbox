using System;
using System.Collections.Generic;
using System.Linq;

namespace PairwiseProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Convert.ToInt32(Console.ReadLine());
            var array = new List<long>();
            var num = Console.ReadLine().Split(' ');
            for (int i = 0;i<size;i++)
            {
                array.Add(Convert.ToInt32(num[i]));
            }
            var max1 = array.Max();
            array.Remove(max1);
            var max2 = array.Max();
            Console.WriteLine(max1 * max2);
            //Console.ReadLine();
        }
    }
}
