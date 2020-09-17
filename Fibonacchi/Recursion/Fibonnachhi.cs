using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Convert.ToInt32(Console.ReadLine());
            var Fib = new List<long>();
            for (int i = 0; i <= num; i++)
            {
                Fib.Add(Fibonachhi(i));
            }
            foreach (int j in Fib) {
                Console.Write(j);
                Console.Write(" ");
            }
        }
        static int Fibonachhi(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return (Fibonachhi(n - 1) + Fibonachhi(n - 2));
        }
    }
}
